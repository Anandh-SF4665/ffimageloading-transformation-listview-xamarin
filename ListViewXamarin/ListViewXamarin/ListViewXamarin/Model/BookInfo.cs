using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using FFImageLoading.Work;
using ImageSource = Xamarin.Forms.ImageSource;

namespace ListViewXamarin
{
    public class BookInfo : INotifyPropertyChanged
    {
        #region Fields

        private string bookName;
        private string bookDesc;
        private string bookAuthor;
        private ImageSource _authorImage;
        private List<ITransformation> transformations;

        #endregion

        #region Constructor

        public BookInfo()
        {
            transformations = new List<ITransformation>();
        }

        #endregion

        #region Properties

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }

        public string BookDescription
        {
            get { return bookDesc; }
            set
            {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public string BookAuthor
        {
            get { return bookAuthor; }
            set
            {
                bookAuthor = value;
                OnPropertyChanged("BookAuthor");
            }
        }

        public ImageSource AuthorImage
        {
            get { return _authorImage; }
            set
            {
                _authorImage = value;
                OnPropertyChanged("AuthorImage");
            }
        }

        public List<ITransformation> Tranformations
        {
            get { return transformations; }
            set 
            { 
                transformations = value; 
                this.OnPropertyChanged("Tranformations"); 
            }
        }
        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
