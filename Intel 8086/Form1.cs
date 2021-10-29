using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel_8086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();



            if (memactiv != 1)
            {
                for (int i = 0; i < memory.Length; i++)
                {
                    memory[i] = "00";
                    if (i == memory.Length)
                    {
                        memactiv = 1;
                    }
                }
                
            }

            if (stackactiv != 1)
            {
                for (int i = 0; i < stack.Length; i++)
                {
                    stack[i] = "00";
                    if (i == stack.Length)
                    {
                        stackactiv = 1;
                    }
                }

            }

        }

        string[] stack = new string[65536];
        string[] memory = new string[65536];

        int stackactiv = 0;
        int memactiv = 0;


        private void Reset1_Click(object sender, EventArgs e)
        {
         

            AX_text.Text = "0000";
            BX_text.Text = "0000";
            CX_text.Text = "0000";
            DX_text.Text = "0000";

            AX_text_2.Text = "0000";
            BX_text_2.Text = "0000";
            CX_text_2.Text = "0000";
            DX_text_2.Text = "0000";

        }

        private void Reset2_Click(object sender, EventArgs e)
        {

            SI_text.Text = "0000";
            DI_text.Text = "0000";
            BP_text.Text = "0000";
            SP_text.Text = "0000";
            DISP_text.Text = "0000";

            SI_text_2.Text = "0000";
            DI_text_2.Text = "0000";
            BP_text_2.Text = "0000";
            SP_text_2.Text = "0000";
            DISP_text_2.Text = "0000";

        }

        private void BX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = BX_text.Text;

        }

        private void CX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = CX_text.Text;

        }

        private void DX_TO_AX_Click(object sender, EventArgs e)
        {

            AX_text.Text = DX_text.Text;

        }

        private void AX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = AX_text.Text;

        }

        private void CX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = CX_text.Text;

        }

        private void DX_TO_BX_Click(object sender, EventArgs e)
        {

            BX_text.Text = DX_text.Text;

        }

        private void AX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = AX_text.Text;

        }

        private void BX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = BX_text.Text;

        }

        private void DX_TO_CX_Click(object sender, EventArgs e)
        {

            CX_text.Text = DX_text.Text;

        }

        private void AX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = AX_text.Text;

        }

        private void BX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = BX_text.Text;

        }

        private void CX_TO_DX_Click(object sender, EventArgs e)
        {

            DX_text.Text = CX_text.Text;

        }

        private void XCHG_AX_BX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_AX_CX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void XCHG_AX_DX_Click(object sender, EventArgs e)
        {

            string a = AX_text.Text;
            AX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_BX_AX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_BX_CX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void XCHG_BX_DX_Click(object sender, EventArgs e)
        {

            string a = BX_text.Text;
            BX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_CX_AX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_CX_BX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_CX_DX_Click(object sender, EventArgs e)
        {

            string a = CX_text.Text;
            CX_text.Text = DX_text.Text;
            DX_text.Text = a;

        }

        private void XCHG_DX_AX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = AX_text.Text;
            AX_text.Text = a;

        }

        private void XCHG_DX_BX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = BX_text.Text;
            BX_text.Text = a;

        }

        private void XCHG_DX_CX_Click(object sender, EventArgs e)
        {

            string a = DX_text.Text;
            DX_text.Text = CX_text.Text;
            CX_text.Text = a;

        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] value = new int[8];
            string[] value2 = new string[8];

            for (int i = 0; i < value.Length; i++)
            {
                
                value[i] = random.Next(0, 255);
                  
            }
            for (int j = 0; j < value.Length; j++)
            {
                if (value[j]<16)
                {
                   value2[j] = "0"+ Convert.ToString(value[j], 16).ToUpper();
                }
                else
                {
                    value2[j] = Convert.ToString(value[j], 16).ToUpper();
                }
                
            }


            string a1 = value2[0];
            string b1 = value2[1];
            string c1 = value2[2];
            string d1 = value2[3];
            string a2 = value2[4];
            string b2 = value2[5];
            string c2 = value2[6];
            string d2 = value2[7];


            AX_text.Text = a1 + a2;
            BX_text.Text = b1 + b2;
            CX_text.Text = c1 + c2;
            DX_text.Text = d1 + d2;

            AX_text_2.Text = a1 + a2;
            BX_text_2.Text = b1 + b2;
            CX_text_2.Text = c1 + c2;
            DX_text_2.Text = d1 + d2;
        }

        private void Random2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] value = new int[8];
            string[] value2 = new string[8];

            for (int i = 0; i < value.Length; i++)
            {

                value[i] = random.Next(0, 255);

            }
            for (int j = 0; j < value.Length; j++)
            {
                if (value[j] < 16)
                {
                    value2[j] = "0" + Convert.ToString(value[j], 16).ToUpper();
                }
                else
                {
                    value2[j] = Convert.ToString(value[j], 16).ToUpper();
                }

            }

            string a1 = value2[0];
            string b1 = value2[1];
            string c1 = value2[2];
            string d1 = value2[3];
            string a2 = value2[4];
            string b2 = value2[5];
            string c2 = value2[6];
            string d2 = value2[7];
            
            

            SI_text.Text = a1 + a2;
            DI_text.Text = b1 + b2;
            BP_text.Text = c1 + c2;
            DISP_text.Text = d1 + d2;


        }

        private void Mem_move_Click(object sender, EventArgs e)
        {
            
            int SI = int.Parse(SI_text.Text, System.Globalization.NumberStyles.HexNumber);
            int DI = int.Parse(DI_text.Text, System.Globalization.NumberStyles.HexNumber);
            int BP = int.Parse(BP_text.Text, System.Globalization.NumberStyles.HexNumber);
            int BX = int.Parse(BX_text.Text, System.Globalization.NumberStyles.HexNumber);
            int DISP = int.Parse(DISP_text.Text, System.Globalization.NumberStyles.HexNumber);

            int inedx_SI_DISP = SI + DISP;
            int inedx_DI_DISP = DI + DISP;

            int bsae_BX_DISP = BX + DISP;
            int bsae_BP_DISP = BP + DISP;

            int index_base_SI_BX_DISP = SI + BX + DISP;
            int index_base_DI_BX_DISP = DI + BX + DISP;
            int index_base_SI_BP_DISP = SI + BP + DISP;
            int index_base_DI_BP_DISP = DI + BP + DISP;

            string AX1 = AX_text.Text.Remove(2);
            string AX2 = AX_text.Text.Substring(2);
            string BX1 = BX_text.Text.Remove(2);
            string BX2 = BX_text.Text.Substring(2);
            string CX1 = CX_text.Text.Remove(2);
            string CX2 = CX_text.Text.Substring(2);
            string DX1 = DX_text.Text.Remove(2);
            string DX2 = DX_text.Text.Substring(2);


            
            if (Mem_To_Reg.Checked == true)
            {

                if (Index_check.Checked == true)
                {

                    if (SI_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                AX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                AX_text.Text = memory[inedx_SI_DISP] + "00";
                            }

                           

                        }
                        if (BX_check.Checked ==true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                BX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                BX_text.Text = memory[inedx_SI_DISP] + "00";
                            }


                        }
                        if (CX_check.Checked == true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                CX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                CX_text.Text = memory[inedx_SI_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                DX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                DX_text.Text = memory[inedx_SI_DISP] + "00";
                            }

                        }

                    }
                    if (DI_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            
                            if (inedx_DI_DISP <= 65534)
                            {
                                AX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                AX_text.Text = memory[inedx_DI_DISP] + "00";
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                BX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                BX_text.Text = memory[inedx_DI_DISP] + "00";
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                CX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                CX_text.Text = memory[inedx_DI_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                DX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                DX_text.Text = memory[inedx_DI_DISP] + "00";
                            }

                        }

                    }

                }

                if (Base_check.Checked == true)
                {

                    if (BX2_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                AX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                AX_text.Text = memory[bsae_BX_DISP] + "00";
                            }

                        }
                        if (BX_check.Checked == true)
                        {

                            if (inedx_DI_DISP <= 65534)
                            {
                                BX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                BX_text.Text = memory[bsae_BX_DISP] + "00";
                            }
                            
                        }
                        if (CX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                CX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                CX_text.Text = memory[bsae_BX_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                DX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                DX_text.Text = memory[bsae_BX_DISP] + "00";
                            }

                        }

                    }

                    if (BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            AX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
   
                        }
                        if (BX_check.Checked == true)
                        {

                            BX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];

                        }
                        if (CX_check.Checked == true)
                        {

                            CX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];

                        }
                        if (DX_check.Checked == true)
                        {

                            DX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];

                        }

                    }

                }

                if (Index_base_check.Checked == true )
                {
                    if (SI_BX_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                AX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                AX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                BX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                BX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                CX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                CX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                DX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                DX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            }

                        }

                    }

                    if (DI_BX_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                AX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                AX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                BX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                BX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                CX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                CX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                DX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                DX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            }

                        }

                    }

                    if (SI_BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                AX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                AX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            }

                        }
                        if (BX_check.Checked == true)
                        {

                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                BX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                BX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            }

                        }
                        if (CX_check.Checked == true)
                        {

                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                CX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                CX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {

                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                DX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                DX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            }

                        }

                    }

                    if (DI_BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                AX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                AX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                BX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                BX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            }
                        
                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                CX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                CX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                DX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                DX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            }

                        }

                    }

                }

            }
           
            if (Reg_To_Mem.Checked == true)
            {

                if (Index_check.Checked == true)
                {

                    if (SI_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {

                            if (inedx_SI_DISP <= 65534)
                            {
                                memory[inedx_SI_DISP] = AX1;
                                memory[inedx_SI_DISP + 1] = AX2;
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                memory[inedx_SI_DISP] = AX1;
                            }
                            

                        }
                        if (BX_check.Checked ==true)
                        {
                            if (inedx_SI_DISP <= 65534)
                            {
                                memory[inedx_SI_DISP] = BX1;
                                memory[inedx_SI_DISP + 1] = BX2;
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                memory[inedx_SI_DISP] = BX1;
                            }
                            
                        }
                        if (CX_check.Checked == true)
                        {
                            if (inedx_SI_DISP <= 65534)
                            {
                                memory[inedx_SI_DISP] = CX1;
                                memory[inedx_SI_DISP + 1] = CX2;
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                memory[inedx_SI_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (inedx_SI_DISP <= 65534)
                            {
                                memory[inedx_SI_DISP] = DX1;
                                memory[inedx_SI_DISP + 1] = DX2;
                            }
                            else if (inedx_SI_DISP <= 65535)
                            {
                                memory[inedx_SI_DISP] = DX1;
                            }

                        }

                    }

                    if (DI_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                memory[inedx_DI_DISP] = AX1;
                                memory[inedx_DI_DISP + 1] = AX2;
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                memory[inedx_DI_DISP] = AX1;
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                memory[inedx_DI_DISP] = BX1;
                                memory[inedx_DI_DISP + 1] = BX2;
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                memory[inedx_DI_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                memory[inedx_DI_DISP] = CX1;
                                memory[inedx_DI_DISP + 1] = CX2;
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                memory[inedx_DI_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (inedx_DI_DISP <= 65534)
                            {
                                memory[inedx_DI_DISP] = DX1;
                                memory[inedx_DI_DISP + 1] = DX2;
                            }
                            else if (inedx_DI_DISP <= 65535)
                            {
                                memory[inedx_DI_DISP] = DX1;
                            }

                        }

                    }

                }

                if (Base_check.Checked == true)
                {

                    if (BX2_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (bsae_BX_DISP <= 65534)
                            {
                                memory[bsae_BX_DISP] = AX1;
                                memory[bsae_BX_DISP + 1] = AX2;
                            }
                            else if (bsae_BX_DISP <= 65535)
                            {
                                memory[bsae_BX_DISP] = AX1;
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (bsae_BX_DISP <= 65534)
                            {
                                memory[bsae_BX_DISP] = BX1;
                                memory[bsae_BX_DISP + 1] = BX2;
                            }
                            else if (bsae_BX_DISP <= 65535)
                            {
                                memory[bsae_BX_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (bsae_BX_DISP <= 65534)
                            {
                                memory[bsae_BX_DISP] = CX1;
                                memory[bsae_BX_DISP + 1] = CX2;
                            }
                            else if (bsae_BX_DISP <= 65535)
                            {
                                memory[bsae_BX_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (bsae_BX_DISP <= 65534)
                            {
                                memory[bsae_BX_DISP] = DX1;
                                memory[bsae_BX_DISP + 1] = DX2;
                            }
                            else if (bsae_BX_DISP <= 65535)
                            {
                                memory[bsae_BX_DISP] = DX1;
                            }
                           

                        }

                    }

                    if (BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (bsae_BP_DISP <= 65534)
                            {
                                memory[bsae_BP_DISP] = AX1;
                                memory[bsae_BP_DISP + 1] = AX2;

                            }
                            else if (bsae_BP_DISP <= 65535)
                            {
                                memory[bsae_BP_DISP] = AX1;
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (bsae_BP_DISP <= 65534)
                            {
                                memory[bsae_BP_DISP] = BX1;
                                memory[bsae_BP_DISP + 1] = BX2;

                            }
                            else if (bsae_BP_DISP <= 65535)
                            {
                                memory[bsae_BP_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (bsae_BP_DISP <= 65534)
                            {
                                memory[bsae_BP_DISP] = CX1;
                                memory[bsae_BP_DISP + 1] = CX2;

                            }
                            else if (bsae_BP_DISP <= 65535)
                            {
                                memory[bsae_BP_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (bsae_BP_DISP <= 65534)
                            {
                                memory[bsae_BP_DISP] = DX1;
                                memory[bsae_BP_DISP + 1] = DX2;

                            }
                            else if (bsae_BP_DISP <= 65535)
                            {
                                memory[bsae_BP_DISP] = DX1;
                            }

                        }

                    }

                }

                if (Index_base_check.Checked == true )
                {
                    if (SI_BX_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                memory[index_base_SI_BX_DISP] = AX1;
                                memory[index_base_SI_BX_DISP + 1] = AX2;
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                memory[index_base_SI_BX_DISP] = AX1;
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {

                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                memory[index_base_SI_BX_DISP] = BX1;
                                memory[index_base_SI_BX_DISP + 1] = BX2;
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                memory[index_base_SI_BX_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                memory[index_base_SI_BX_DISP] = CX1;
                                memory[index_base_SI_BX_DISP + 1] = CX2;
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                memory[index_base_SI_BX_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_SI_BX_DISP <= 65534)
                            {
                                memory[index_base_SI_BX_DISP] = DX1;
                                memory[index_base_SI_BX_DISP + 1] = DX2;
                            }
                            else if (index_base_SI_BX_DISP <= 65535)
                            {
                                memory[index_base_SI_BX_DISP] = DX1;
                            }

                        }

                    }

                    if (DI_BX_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                memory[index_base_DI_BX_DISP] = AX1;
                                memory[index_base_DI_BX_DISP + 1] = AX2;
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                memory[index_base_DI_BX_DISP] = AX1;
                            }

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                memory[index_base_DI_BX_DISP] = BX1;
                                memory[index_base_DI_BX_DISP + 1] = BX2;
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                memory[index_base_DI_BX_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                memory[index_base_DI_BX_DISP] = CX1;
                                memory[index_base_DI_BX_DISP + 1] = CX2;
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                memory[index_base_DI_BX_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_DI_BX_DISP <= 65534)
                            {
                                memory[index_base_DI_BX_DISP] = DX1;
                                memory[index_base_DI_BX_DISP + 1] = DX2;
                            }
                            else if (index_base_DI_BX_DISP <= 65535)
                            {
                                memory[index_base_DI_BX_DISP] = DX1;
                            }

                        }

                    }

                    if (SI_BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                memory[index_base_SI_BP_DISP] = AX1;
                                memory[index_base_SI_BP_DISP + 1] = AX2;
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                memory[index_base_SI_BP_DISP] = AX1;
                            }
                           

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                memory[index_base_SI_BP_DISP] = BX1;
                                memory[index_base_SI_BP_DISP + 1] = BX2;
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                memory[index_base_SI_BP_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                memory[index_base_SI_BP_DISP] = CX1;
                                memory[index_base_SI_BP_DISP + 1] = CX2;
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                memory[index_base_SI_BP_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_SI_BP_DISP <= 65534)
                            {
                                memory[index_base_SI_BP_DISP] = DX1;
                                memory[index_base_SI_BP_DISP + 1] = DX2;
                            }
                            else if (index_base_SI_BP_DISP <= 65535)
                            {
                                memory[index_base_SI_BP_DISP] = DX1;
                            }

                        }

                    }

                    if (DI_BP_check.Checked == true)
                    {

                        if (AX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                memory[index_base_DI_BP_DISP] = AX1;
                                memory[index_base_DI_BP_DISP + 1] = AX2;
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                memory[index_base_DI_BP_DISP] = AX1;
                            }
                            

                        }
                        if (BX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                memory[index_base_DI_BP_DISP] = BX1;
                                memory[index_base_DI_BP_DISP + 1] = BX2;
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                memory[index_base_DI_BP_DISP] = BX1;
                            }

                        }
                        if (CX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                memory[index_base_DI_BP_DISP] = CX1;
                                memory[index_base_DI_BP_DISP + 1] = CX2;
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                memory[index_base_DI_BP_DISP] = CX1;
                            }

                        }
                        if (DX_check.Checked == true)
                        {
                            if (index_base_DI_BP_DISP <= 65534)
                            {
                                memory[index_base_DI_BP_DISP] = DX1;
                                memory[index_base_DI_BP_DISP + 1] = DX2;
                            }
                            else if (index_base_DI_BP_DISP <= 65535)
                            {
                                memory[index_base_DI_BP_DISP] = DX1;
                            }

                        }

                    }

                }

            }

                       
        }


        private void Mem_Xchg_Click(object sender, EventArgs e)
        {
            

            int SI = int.Parse(SI_text.Text, System.Globalization.NumberStyles.HexNumber);
            int DI = int.Parse(DI_text.Text, System.Globalization.NumberStyles.HexNumber);
            int BP = int.Parse(BP_text.Text, System.Globalization.NumberStyles.HexNumber);
            int BX = int.Parse(BX_text.Text, System.Globalization.NumberStyles.HexNumber);
            int DISP = int.Parse(DISP_text.Text, System.Globalization.NumberStyles.HexNumber);

            int inedx_SI_DISP = SI + DISP;
            int inedx_DI_DISP = DI + DISP;

            int bsae_BX_DISP = BX + DISP;
            int bsae_BP_DISP = BP + DISP;

            int index_base_SI_BX_DISP = SI + BX + DISP;
            int index_base_DI_BX_DISP = DI + BX + DISP;
            int index_base_SI_BP_DISP = SI + BP + DISP;
            int index_base_DI_BP_DISP = DI + BP + DISP;

            string AX1 = AX_text.Text.Remove(2);
            string AX2 = AX_text.Text.Substring(2);
            string BX1 = BX_text.Text.Remove(2);
            string BX2 = BX_text.Text.Substring(2);
            string CX1 = CX_text.Text.Remove(2);
            string CX2 = CX_text.Text.Substring(2);
            string DX1 = DX_text.Text.Remove(2);
            string DX2 = DX_text.Text.Substring(2);

            if (Index_check.Checked == true)
            {

                if (SI_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (inedx_SI_DISP <= 65534)
                        {
                            AX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            memory[inedx_SI_DISP] = AX1;
                            memory[inedx_SI_DISP + 1] = AX2;
                        }
                        else if (inedx_SI_DISP <= 65535)
                        {
                            AX_text.Text = memory[inedx_SI_DISP] + "00";
                            memory[inedx_SI_DISP] = AX1;
                        }                       

                    }
                    if (BX_check.Checked == true)
                    {
                        if (inedx_SI_DISP <= 65534)
                        {
                            BX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            memory[inedx_SI_DISP] = BX1;
                            memory[inedx_SI_DISP + 1] = BX2;
                        }
                        else if (inedx_SI_DISP <= 65535)
                        {
                            BX_text.Text = memory[inedx_SI_DISP] + "00";
                            memory[inedx_SI_DISP] = BX1;
                        }

                    }
                    if (CX_check.Checked == true)
                    {
                        if (inedx_SI_DISP <= 65534)
                        {
                            CX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            memory[inedx_SI_DISP] = CX1;
                            memory[inedx_SI_DISP + 1] = CX2;
                        }
                        else if (inedx_SI_DISP <= 65535)
                        {
                            CX_text.Text = memory[inedx_SI_DISP] + "00";
                            memory[inedx_SI_DISP] = CX1;
                        }                       

                    }
                    if (DX_check.Checked == true)
                    {
                        if (inedx_SI_DISP <= 65534)
                        {
                            DX_text.Text = memory[inedx_SI_DISP] + memory[inedx_SI_DISP + 1];
                            memory[inedx_SI_DISP] = DX1;
                            memory[inedx_SI_DISP + 1] = DX2;
                        }
                        else if (inedx_SI_DISP <= 65535)
                        {
                            DX_text.Text = memory[inedx_SI_DISP] + "00";
                            memory[inedx_SI_DISP] = DX1;
                        }                       

                    }

                }
                if (DI_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (inedx_DI_DISP <= 65534)
                        {
                            AX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            memory[inedx_DI_DISP] = AX1;
                            memory[inedx_DI_DISP + 1] = AX2;
                        }
                        else if (inedx_DI_DISP <= 65535)
                        {
                            AX_text.Text = memory[inedx_DI_DISP] + "00";
                            memory[inedx_DI_DISP] = AX1;
                        }
                        

                    }
                    if (BX_check.Checked == true)
                    {
                        if (inedx_DI_DISP <= 65534)
                        {
                            BX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            memory[inedx_DI_DISP] = BX1;
                            memory[inedx_DI_DISP + 1] = BX2;

                        }
                        else if (inedx_DI_DISP <= 65535)
                        {
                            BX_text.Text = memory[inedx_DI_DISP] + "00";
                            memory[inedx_DI_DISP] = BX1;
                        }
                       
                    }
                    if (CX_check.Checked == true)
                    {
                        if (inedx_DI_DISP <= 65534)
                        {
                            CX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            memory[inedx_DI_DISP] = CX1;
                            memory[inedx_DI_DISP + 1] = CX2;
                        }
                        else if (inedx_DI_DISP <= 65535)
                        {
                            CX_text.Text = memory[inedx_DI_DISP] + "00";
                            memory[inedx_DI_DISP] = CX1;
                        }
                     

                    }
                    if (DX_check.Checked == true)
                    {
                        if (inedx_DI_DISP <= 65534)
                        {
                            DX_text.Text = memory[inedx_DI_DISP] + memory[inedx_DI_DISP + 1];
                            memory[inedx_DI_DISP] = DX1;
                            memory[inedx_DI_DISP + 1] = DX2;
                        }
                        else if (inedx_DI_DISP <= 65535)
                        {
                            DX_text.Text = memory[inedx_DI_DISP] + "00";
                            memory[inedx_DI_DISP] = DX1;
                        }
                       

                    }

                }

            }

            if (Base_check.Checked == true)
            {

                if (BX2_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (bsae_BX_DISP <= 65534)
                        {
                            AX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            memory[bsae_BX_DISP] = AX1;
                            memory[bsae_BX_DISP + 1] = AX2;
                        }
                        else if (bsae_BX_DISP <= 65535)
                        {
                            AX_text.Text = memory[bsae_BX_DISP] + "00";
                            memory[bsae_BX_DISP] = AX1;
                        }
                       

                    }
                    if (BX_check.Checked == true)
                    {
                        if (bsae_BX_DISP <= 65534)
                        {
                            BX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            memory[bsae_BX_DISP] = BX1;
                            memory[bsae_BX_DISP + 1] = BX2;
                        }
                        else if (bsae_BX_DISP <= 65535)
                        {
                            BX_text.Text = memory[bsae_BX_DISP] + "00";
                            memory[bsae_BX_DISP] = BX1;
                        }
                        

                    }
                    if (CX_check.Checked == true)
                    {
                        if (bsae_BX_DISP <= 65534)
                        {
                            CX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            memory[bsae_BX_DISP] = CX1;
                            memory[bsae_BX_DISP + 1] = CX2;
                        }
                        else if (bsae_BX_DISP <= 65535)
                        {
                            CX_text.Text = memory[bsae_BX_DISP] + "00";
                            memory[bsae_BX_DISP] = CX1;
                        }
                      

                    }
                    if (DX_check.Checked == true)
                    {
                        if (bsae_BX_DISP <= 65534)
                        {
                            DX_text.Text = memory[bsae_BX_DISP] + memory[bsae_BX_DISP + 1];
                            memory[bsae_BX_DISP] = DX1;
                            memory[bsae_BX_DISP + 1] = DX2;
                        }
                        else if (bsae_BX_DISP <= 65535)
                        {
                            DX_text.Text = memory[bsae_BX_DISP] + "00";
                            memory[bsae_BX_DISP] = DX1;
                        }
                    
                    }

                }

                if (BP_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (bsae_BP_DISP <= 65534)
                        {
                            AX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
                            memory[bsae_BP_DISP] = AX1;
                            memory[bsae_BP_DISP + 1] = AX2;
                        }
                        else if (bsae_BP_DISP <= 65535)
                        {
                            AX_text.Text = memory[bsae_BP_DISP] + "00";
                            memory[bsae_BP_DISP] = AX1;
                        }
                        

                    }
                    if (BX_check.Checked == true)
                    {
                        if (bsae_BP_DISP <= 65534)
                        {
                            BX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
                            memory[bsae_BP_DISP] = BX1;
                            memory[bsae_BP_DISP + 1] = BX2;
                        }
                        else if (bsae_BP_DISP <= 65535)
                        {
                            BX_text.Text = memory[bsae_BP_DISP] + "00";
                            memory[bsae_BP_DISP] = BX1;
                        }
                        

                    }
                    if (CX_check.Checked == true)
                    {
                        if (bsae_BP_DISP <= 65534)
                        {
                            CX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
                            memory[bsae_BP_DISP] = CX1;
                            memory[bsae_BP_DISP + 1] = CX2;
                        }
                        else if (bsae_BP_DISP <= 65535)
                        {
                            CX_text.Text = memory[bsae_BP_DISP] + "00";
                            memory[bsae_BP_DISP] = CX1;
                        }
                       

                    }
                    if (DX_check.Checked == true)
                    {
                        if (bsae_BP_DISP <= 65534)
                        {
                            DX_text.Text = memory[bsae_BP_DISP] + memory[bsae_BP_DISP + 1];
                            memory[bsae_BP_DISP] = DX1;
                            memory[bsae_BP_DISP + 1] = DX2;
                        }
                        else if (bsae_BP_DISP <= 65535)
                        {
                            DX_text.Text = memory[bsae_BP_DISP] + "00";
                            memory[bsae_BP_DISP] = DX1;
                        }
                      

                    }

                }

            }

            if (Index_base_check.Checked == true)
            {
                if (SI_BX_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (index_base_SI_BX_DISP <= 65534)
                        {
                            AX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            memory[index_base_SI_BX_DISP] = AX1;
                            memory[index_base_SI_BX_DISP + 1] = AX2;
                        }
                        else if (index_base_SI_BX_DISP <= 65535)
                        {
                            AX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            memory[index_base_SI_BX_DISP] = AX1;
                        }                       

                    }
                    if (BX_check.Checked == true)
                    {
                        if (index_base_SI_BX_DISP <= 65534)
                        {
                            BX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            memory[index_base_SI_BX_DISP] = BX1;
                            memory[index_base_SI_BX_DISP + 1] = BX2;
                        }
                        else if (index_base_SI_BX_DISP <= 65535)
                        {
                            BX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            memory[index_base_SI_BX_DISP] = BX1;
                        }
                        

                    }
                    if (CX_check.Checked == true)
                    {
                        if (index_base_SI_BX_DISP <= 65534)
                        {
                            CX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            memory[index_base_SI_BX_DISP] = CX1;
                            memory[index_base_SI_BX_DISP + 1] = CX2;
                        }
                        else if (index_base_SI_BX_DISP <= 65535)
                        {
                            CX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            memory[index_base_SI_BX_DISP] = CX1;
                        }
                    

                    }
                    if (DX_check.Checked == true)
                    {
                        if (index_base_SI_BX_DISP <= 65534)
                        {
                            DX_text.Text = memory[index_base_SI_BX_DISP] + memory[index_base_SI_BX_DISP + 1];
                            memory[index_base_SI_BX_DISP] = DX1;
                            memory[index_base_SI_BX_DISP + 1] = DX2;
                        }
                        else if (index_base_SI_BX_DISP <= 65535)
                        {
                            DX_text.Text = memory[index_base_SI_BX_DISP] + "00";
                            memory[index_base_SI_BX_DISP] = DX1;
                        }
                   

                    }

                }

                if (DI_BX_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (index_base_DI_BX_DISP <= 65534)
                        {
                            AX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            memory[index_base_DI_BX_DISP] = AX1;
                            memory[index_base_DI_BX_DISP + 1] = AX2;
                        }
                        else if (index_base_DI_BX_DISP <= 65535)
                        {
                            AX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            memory[index_base_DI_BX_DISP] = AX1;
                        }
                       

                    }
                    if (BX_check.Checked == true)
                    {
                        if (index_base_DI_BX_DISP <= 65534)
                        {
                            BX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            memory[index_base_DI_BX_DISP] = BX1;
                            memory[index_base_DI_BX_DISP + 1] = BX2;
                        }
                        else if (index_base_DI_BX_DISP <= 65535)
                        {
                            BX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            memory[index_base_DI_BX_DISP] = BX1;
                        }
                        

                    }
                    if (CX_check.Checked == true)
                    {
                        if (index_base_DI_BX_DISP <= 65534)
                        {
                            CX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            memory[index_base_DI_BX_DISP] = CX1;
                            memory[index_base_DI_BX_DISP + 1] = CX2;
                        }
                        else if (index_base_DI_BX_DISP <= 65535)
                        {
                            CX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            memory[index_base_DI_BX_DISP] = CX1;
                        }
                  

                    }
                    if (DX_check.Checked == true)
                    {
                        if (index_base_DI_BX_DISP <= 65534)
                        {
                            DX_text.Text = memory[index_base_DI_BX_DISP] + memory[index_base_DI_BX_DISP + 1];
                            memory[index_base_DI_BX_DISP] = DX1;
                            memory[index_base_DI_BX_DISP + 1] = DX2;
                        }
                        else if (index_base_DI_BX_DISP <= 65535)
                        {
                            DX_text.Text = memory[index_base_DI_BX_DISP] + "00";
                            memory[index_base_DI_BX_DISP] = DX1;
                        }
                     

                    }

                }

                if (SI_BP_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (index_base_SI_BP_DISP <= 65534)
                        {
                            AX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            memory[index_base_SI_BP_DISP] = AX1;
                            memory[index_base_SI_BP_DISP + 1] = AX2;
                        }
                        else if (index_base_SI_BP_DISP <= 65535)
                        {
                            AX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            memory[index_base_SI_BP_DISP] = AX1;
                        }
                        

                    }
                    if (BX_check.Checked == true)
                    {
                        if (index_base_SI_BP_DISP <= 65534)
                        {
                            BX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            memory[index_base_SI_BP_DISP] = BX1;
                            memory[index_base_SI_BP_DISP + 1] = BX2;
                        }
                        else if (index_base_SI_BP_DISP <= 65535)
                        {
                            BX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            memory[index_base_SI_BP_DISP] = BX1;
                        }
                       

                    }
                    if (CX_check.Checked == true)
                    {
                        if (index_base_SI_BP_DISP <= 65534)
                        {
                            CX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            memory[index_base_SI_BP_DISP] = CX1;
                            memory[index_base_SI_BP_DISP + 1] = CX2;
                        }
                        else if (index_base_SI_BP_DISP <= 65535)
                        {
                            CX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            memory[index_base_SI_BP_DISP] = CX1;
                        }
                        

                    }
                    if (DX_check.Checked == true)
                    {
                        if (index_base_SI_BP_DISP <= 65534)
                        {
                            DX_text.Text = memory[index_base_SI_BP_DISP] + memory[index_base_SI_BP_DISP + 1];
                            memory[index_base_SI_BP_DISP] = DX1;
                            memory[index_base_SI_BP_DISP + 1] = DX2;
                        }
                        else if (index_base_SI_BP_DISP <= 65535)
                        {
                            DX_text.Text = memory[index_base_SI_BP_DISP] + "00";
                            memory[index_base_SI_BP_DISP] = DX1;
                        }                      
                    }

                }

                if (DI_BP_check.Checked == true)
                {

                    if (AX_check.Checked == true)
                    {
                        if (index_base_DI_BP_DISP <= 65534)
                        {
                            AX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            memory[index_base_DI_BP_DISP] = AX1;
                            memory[index_base_DI_BP_DISP + 1] = AX2;
                        }
                        else if (index_base_DI_BP_DISP <= 65535)
                        {
                            AX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            memory[index_base_DI_BP_DISP] = AX1;
                        }
                        

                    }
                    if (BX_check.Checked == true)
                    {
                        if (index_base_DI_BP_DISP <= 65534)
                        {
                            BX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            memory[index_base_DI_BP_DISP] = BX1;
                            memory[index_base_DI_BP_DISP + 1] = BX2;
                        }
                        else if (index_base_DI_BP_DISP <= 65535)
                        {
                            BX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            memory[index_base_DI_BP_DISP] = BX1;
                        }
                      

                    }
                    if (CX_check.Checked == true)
                    {
                        if (index_base_DI_BP_DISP <= 65534)
                        {
                            CX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            memory[index_base_DI_BP_DISP] = CX1;
                            memory[index_base_DI_BP_DISP + 1] = CX2;
                        }
                        else if (index_base_DI_BP_DISP <= 65535)
                        {
                            CX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            memory[index_base_DI_BP_DISP] = CX1;
                        }
                        

                    }
                    if (DX_check.Checked == true)
                    {
                        if (index_base_DI_BP_DISP <= 65534)
                        {
                            DX_text.Text = memory[index_base_DI_BP_DISP] + memory[index_base_DI_BP_DISP + 1];
                            memory[index_base_DI_BP_DISP] = DX1;
                            memory[index_base_DI_BP_DISP + 1] = DX2;
                        }
                        else if (index_base_DI_BP_DISP <= 65535)
                        {
                            DX_text.Text = memory[index_base_DI_BP_DISP] + "00";
                            memory[index_base_DI_BP_DISP] = DX1;
                        }
                       

                    }

                }

            }

        }

        private void Push_AX_Click(object sender, EventArgs e)
        {

            int SP = int.Parse(SP_text.Text, System.Globalization.NumberStyles.HexNumber);

            if (SP <= 65534)
            {
                int SP2 = SP + 2;

                string AX1 = AX_text.Text.Remove(2);
                string AX2 = AX_text.Text.Substring(2);

                stack[SP] = AX1;
                stack[SP + 1] = AX2;
                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }

            }

            else if (SP <= 65535)
            {
                int SP2 = SP;
                string AX1 = AX_text.Text.Remove(2);
                stack[SP] = AX1;

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }         

        }

        private void Push_BX_Click(object sender, EventArgs e)
        {

            int SP = int.Parse(SP_text.Text, System.Globalization.NumberStyles.HexNumber);           

            if (SP <= 65534)
            {
                int SP2 = SP + 2;

                string BX1 = BX_text.Text.Remove(2);
                string BX2 = BX_text.Text.Substring(2);

                stack[SP] = BX1;
                stack[SP + 1] = BX2;

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }

            else if (SP <= 65535)
            {
                int SP2 = SP;

                string BX1 = BX_text.Text.Remove(2);

                stack[SP] = BX1;

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }
           
        }

        private void Push_CX_Click(object sender, EventArgs e)
        {

            int SP = int.Parse(SP_text.Text, System.Globalization.NumberStyles.HexNumber);

            if (SP <= 65534)
            {
                int SP2 = SP + 2;

                string CX1 = CX_text.Text.Remove(2);
                string CX2 = CX_text.Text.Substring(2);

                stack[SP] = CX1;
                stack[SP + 1] = CX2;

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }
            else if (SP <= 65535)
            {
                int SP2 = SP;

                string CX1 = CX_text.Text.Remove(2);

                stack[SP] = CX1;

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }

            }
                

        }

        private void Push_DX_Click(object sender, EventArgs e)
        {

            int SP = int.Parse(SP_text.Text, System.Globalization.NumberStyles.HexNumber);

            if (SP <= 65534)
            {
                int SP2 = SP + 2;

                string DX1 = DX_text.Text.Remove(2);
                string DX2 = DX_text.Text.Substring(2);

                stack[SP] = DX1;
                stack[SP + 1] = DX2;


                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }
            else if (SP <= 65535)
            {

                int SP2 = SP;

                string DX1 = DX_text.Text.Remove(2);

                stack[SP] = DX1;

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }

                

        }

        private void Pop_AX_Click(object sender, EventArgs e)
        {

            int SP = int.Parse(SP_text.Text, System.Globalization.NumberStyles.HexNumber);
            if (SP > 0)
            {
                int SP2 = SP - 2;

                AX_text.Text = stack[SP2] + stack[SP2 + 1];

                stack[SP2] = "00";
                stack[SP2 + 1] = "00";

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }
            

           

        }

        private void Pop_BX_Click(object sender, EventArgs e)
        {

            int SP = int.Parse(SP_text.Text, System.Globalization.NumberStyles.HexNumber);
            if (SP > 0)
            {
                int SP2 = SP - 2;

                BX_text.Text = stack[SP2] + stack[SP2 + 1];

                stack[SP2] = "00";
                stack[SP2 + 1] = "00";

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }
            

        }

        private void Pop_CX_Click(object sender, EventArgs e)
        {

            int SP = int.Parse(SP_text.Text, System.Globalization.NumberStyles.HexNumber);
            
            if (SP > 0)
            {
                int SP2 = SP - 2;

                CX_text.Text = stack[SP2] + stack[SP2 + 1];

                stack[SP2] = "00";
                stack[SP2 + 1] = "00";

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }
            }

               

        }

        private void Pop_DX_Click(object sender, EventArgs e)
        {

            int SP = int.Parse(SP_text.Text, System.Globalization.NumberStyles.HexNumber);

            if (SP > 0)
            {

                int SP2 = SP - 2;

                DX_text.Text = stack[SP2] + stack[SP2 + 1];

                stack[SP2] = "00";
                stack[SP2 + 1] = "00";

                if (SP2 >= 256 && SP2 <= 4095)
                {

                    SP_text.Text = ($"0{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 >= 16 && SP2 <= 255)
                {

                    SP_text.Text = ($"00{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 < 16)
                {

                    SP_text.Text = ($"000{Convert.ToString(SP2, 16).ToUpper()}");

                }
                if (SP2 > 4095)
                {

                    SP_text.Text = Convert.ToString(SP2, 16).ToUpper();

                }

            }
               

        }

        private void Show_Memory_Click(object sender, EventArgs e)
        {
        

            for (int i = 0; i < memory.Length; i++)
            {
                

                Console.WriteLine($"{i} {memory[i]}");

            }

        }
        
    }
}
