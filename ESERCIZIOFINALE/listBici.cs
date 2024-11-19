using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESERCIZIOFINALE
{
    internal class listBici
    {
        List<clsBiciElettrica> listBiciElettrica = new List<clsBiciElettrica>();
        public void inserire(clsBiciElettrica bici)
        {

        }
        public void visualizzare(DataGridView dgv)
        {
            if(listBiciElettrica!=null&& listBiciElettrica.Count > 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = listBiciElettrica/*.ToArray()*/;
            }
        }
        public void eliminare(DataGridView dgv,int index)
        {
            if (index > 0 && index < listBiciElettrica.Count)
            {
                listBiciElettrica.RemoveAt(index);
                visualizzare(dgv);
            }
        }
    }
}
