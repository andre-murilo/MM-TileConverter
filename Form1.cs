using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MixMaster_Tile_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region funcoes_utilitarias

        public int GetFramesInTile(string path)
        {
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(path)))
            {
                using (BinaryReader br = new BinaryReader(ms, Encoding.UTF8))
                {
                    int NFrames = br.ReadInt32();
                    return NFrames;
                }
            }
        }
        #endregion




        private void BTNProcess_Click(object sender, EventArgs e)
        {
            if(!File.Exists(TBInput.Text)) { MessageBox.Show("Diretório de entrada invalido."); return; }
            if(TBOutput.Text == string.Empty) { MessageBox.Show("Diretório de saida invalido."); return; }

   
           ConvertTileToAn();
 
        }
        


        private void ConvertTileToAn()
        {
           
            int NFrames = GetFramesInTile(TBInput.Text);

            if (File.Exists(TBOutput.Text))
                File.Delete(TBOutput.Text);

            //File.Create(TBOutput.Text);



            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(TBInput.Text)))
            {
                using (BinaryReader br = new BinaryReader(ms, Encoding.UTF8))
                {
                    br.ReadInt32();
                    try
                    {
                        using (MemoryStream ms2 = new MemoryStream())
                        {
                            using (BinaryWriter bw = new BinaryWriter(ms2, Encoding.UTF8))
                            {
                                bw.Write((int)NFrames);

                                for(int i = 0; i < NFrames; i++)
                                {
                                    int dataLen = br.ReadInt32();

                                    bw.Write((short)0);
                                    bw.Write((short)0);
                                    bw.Write((short)128);
                                    bw.Write((short)64);
                                    bw.Write((int)dataLen);

      
                                    bw.Write(br.ReadBytes(dataLen));

                               
                                    
                                }
                            }

                            File.WriteAllBytes(TBOutput.Text, ms2.ToArray());
                        }


                            /*
                            while ((DataLen = br.ReadInt32()) > 0)
                            {
                                using (MemoryStream ms2 = new MemoryStream())
                                {
                                    using (BinaryWriter bw = new BinaryWriter(ms2, Encoding.UTF8))
                                    {
                                        if (first)
                                        {
                                            bw.Write((int)NFrames);
                                            first = false;
                                        }
                                        bw.Write((short)0);
                                        bw.Write((short)0);
                                        bw.Write((short)64);
                                        bw.Write((short)32);
                                        bw.Write((int)DataLen);
                                        bw.Write(br.ReadBytes(DataLen));

                                        //byte[] FullData = ms2.GetBuffer();
                                        //Array.Resize(ref FullData, (int)ms2.Length);


                                        //string RealFileName = Path.GetFileNameWithoutExtension(TBInput.Text);

                                        //AppendAllBytes(TBOutput.Text, FullData);
                                    }
                                }
                            }
                            */
                            
                        }
                    catch
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("Concluido!");
        }

        public static void AppendAllBytes(string path, byte[] bytes)
        {
            //argument-checking here.

            using (var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }

        private void BTNBuscarTile_Click(object sender, EventArgs e)
        {
            OpenFileDialog MyFile = new OpenFileDialog();
            MyFile.Title = "Selecione arquivos .Tile";
            MyFile.Filter = "Tile Files | *.tile";
            MyFile.InitialDirectory = Directory.GetCurrentDirectory();

            if( MyFile.ShowDialog() == DialogResult.OK)
            {
                if(MyFile.CheckPathExists)
                {
                    if(MyFile.CheckFileExists)
                    {
                        string FileName = MyFile.FileName;
                        TBInput.Text = FileName;
                    }
                    else
                    {
                        MessageBox.Show("Arquivo não econtrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Diretório invalido!");
                }
            }
            

            
              
        }

        private void BTNBuscarSaida_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Title = "Selecione um diretório para salvar o arquivo!";
                sf.Filter = "An Files | *.an";
                sf.InitialDirectory = Directory.GetCurrentDirectory();

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    string file = sf.FileName;
                    TBOutput.Text = file;
                   
                }

            }
        }

        private void TBInput_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void TBInput_DragEnter(object sender, DragEventArgs e)
        {
            
            
        }

        private void TBInput_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TBOutput_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void TBOutput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // An to Tile

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog MyFile = new OpenFileDialog();
            MyFile.Title = "Selecione arquivos .an";
            MyFile.Filter = "An Files | *.an";
            MyFile.InitialDirectory = Directory.GetCurrentDirectory();

            if (MyFile.ShowDialog() == DialogResult.OK)
            {
                if (MyFile.CheckPathExists)
                {
                    if (MyFile.CheckFileExists)
                    {
                        string FileName = MyFile.FileName;
                        textBox1.Text = FileName;
                    }
                    else
                    {
                        MessageBox.Show("Arquivo não econtrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Diretório invalido!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Title = "Selecione um diretório para salvar o arquivo!";
                sf.Filter = "Tile Files | *.tile";
                sf.InitialDirectory = Directory.GetCurrentDirectory();

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    string file = sf.FileName;
                    textBox2.Text = file;
                }

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
          
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(textBox1.Text)))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    using (MemoryStream ms2 = new MemoryStream())
                    {
                        using (BinaryWriter bw = new BinaryWriter(ms2))
                        {
                            // br => an
                            // bw => tile
                            int frames = br.ReadInt32();
                            bw.Write((int)frames);

                            for (int i = 0; i < frames; i++)
                            {
                                uint offX, offY, x, y;

                                offX = br.ReadUInt16();
                                if(offX == 30000)
                                {
                                    Console.WriteLine($"[{i}] Problem: OffX: {offX}");
                                    bw.Write((int)0);
                                    bw.Write((int)0);
                                    continue;
                                }

                                offY = br.ReadUInt16(); // offset y

                                x = br.ReadUInt16(); // size width
                                y = br.ReadUInt16(); // size height

                                int blockLength = br.ReadInt32();
                                Console.WriteLine($"[{i}] OffX: {offX}, OffY: {offY} | X: {x} : Y: {y} - {blockLength}");

                                bw.Write((int)blockLength);
                                bw.Write(br.ReadBytes(blockLength));
                            }
                        }

                        File.WriteAllBytes(textBox2.Text, ms2.ToArray());
                        MessageBox.Show("Concluido!");
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
