using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetGui.CustomControls
{
    //our goal is to make apanel with some required override functions that allow us to easily create the cards and tile a space

    //

    public partial class card_view_panel : UserControl
    {
        //        public card_view_panel()
        //        {

        //        }

        //        public int CardWidth { get; private set; }
        //        public int CardHeight { get; private set; }

        //        public CardsViewModel ViewModel { get; set; }

        //        public CardsPanel(CardsViewModel viewModel)
        //        {
        //            ViewModel = viewModel;
        //            ViewModel.Cards.CollectionChanged += Cards_CollectionChanged;
        //        }

        //        private void Cards_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //        {
        //            DataBind();
        //        }

        //        public void DataBind()
        //        {
        //            SuspendLayout();
        //            Controls.Clear();

        //            for (int i = 0; i < ViewModel.Cards.Count; i++)
        //            {
        //                var newCtl = new CardControl(ViewModel.Cards[i]);
        //                newCtl.DataBind();
        //                SetCardControlLayout(newCtl, i);
        //                Controls.Add(newCtl);
        //            }
        //            ResumeLayout();
        //        }

        //        void SetCardControlLayout(CardControl ctl, int atIndex)
        //        {
        //            ctl.Width = CardWidth;
        //            ctl.Height = CardHeight;

        //            //calc visible column count
        //            int columnCount = Width / CardWidth;

        //            //calc the x index and y index.
        //            int xPos = (atIndex % columnCount) * CardWidth;
        //            int yPos = (atIndex / columnCount) * CardHeight;

        //            ctl.Location = new Point(xPos, yPos);
        //        }
        //    }

        //    public partial class CardControl : UserControl
        //    {
        //        public CardViewModel ViewModel { get; set; }

        //        public CardControl()
        //        {
        //            InitializeComponent();
        //        }
        //        public CardControl(CardViewModel viewModel)
        //        {
        //            ViewModel = viewModel;
        //            InitializeComponent();
        //        }

        //        public void DataBind()
        //        {
        //            SuspendLayout();

        //            tbAge.Text = ViewModel.Age.ToString();
        //            tbAge.Name = ViewModel.Name;
        //            pbPicture.Image = ViewModel.Picture;

        //            ResumeLayout();
        //        }
        //    }

        //    public class CardsViewModel
        //    {
        //        public ObservableCollection<CardViewModel> Cards { get; set; }
        //    }

        //    public class CardViewModel
        //    {
        //        public string Name { get; set; }
        //        public int Age { get; set; }
        //        public Bitmap Picture { get; set; }
    }
}

