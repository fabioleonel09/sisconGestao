using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisconGestão
{
    public partial class frmAguarde : Form
    {
        public Action Worker { get; set; } //instância de trabalho para a janela de aguarde
        public frmAguarde(Action worker) //assoiciação da instância ao frm
        {
            InitializeComponent();

            if (worker == null) //se não houver a ação
                throw new ArgumentNullException();
            Worker = worker; //do contrário
        }
        protected override void OnLoad(EventArgs e) //evento para fazer o frmAguarde aparecer somente quando tiver a ação
        {
            base.OnLoad(e); //ativa o frm
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext()); //enquanto tiver a ação, o frm está trabalhando
        }
    }
}
