//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BudgetGui.CustomControls
//{
//    public class CardsPanel : Panel
//    {
//        const int CardWidth = 200;
//        const int CardHeight = 150;

//        public CardsViewModel ViewModel { get; set; }

//        public CardsPanel()
//        {
//        }


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
//    }
//}
