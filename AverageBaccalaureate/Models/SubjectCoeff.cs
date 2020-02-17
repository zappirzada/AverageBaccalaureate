using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AverageBaccalaureate.Models
{
    public class SubjectCoeff : INotifyPropertyChanged
    {
        private string name;
        private string type;
        private double coefficient;
        private double coefficientNewValue;
        private bool coefficientChangeable;
        private bool switchToGetCoeff = true;
        private string note;
        private ObservableCollection<SubjectCoeff> listNames;
        private bool showCoefficientChangeable = false;
        private double actualCoefficient;
        private bool showSwitchToGetCoeff;
        private bool showCourseName = true;
        private SubjectCoeff selectedItemFromList;

        public SubjectCoeff()
        {

        }
        public int Id { get; set; }
        public int MajorDisciplineId { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public bool ShowCourseName
        {
            get { return showCourseName; }
            set
            {
                showCourseName = value;
                OnPropertyChanged("ShowCourseName");
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
        public double ActualCoefficient
        {
            get { return actualCoefficient; }
            set
            {
                actualCoefficient = value;
                OnPropertyChanged("ActualCoefficient");
            }
        }
        public double Coefficient
        {
            get { return coefficient; }
            set
            {
                coefficient = value;
                OnPropertyChanged("Coefficient");
            }
        }
        public double CoefficientNewValue
        {
            get { return coefficientNewValue; }
            set
            {
                coefficientNewValue = value;
                OnPropertyChanged("CoefficientNewValue");
            }
        }
        public bool CoefficientChangeable
        {
            get { return coefficientChangeable; }
            set
            {
                coefficientChangeable = value;
                if (value)
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        ActualCoefficient = CoefficientNewValue;
                        SwitchToGetCoeff = false;
                        await Task.Delay(100);
                        SwitchToGetCoeff = true;
                    });
                else
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        ActualCoefficient = Coefficient;
                        SwitchToGetCoeff = false;
                        await Task.Delay(100);
                        SwitchToGetCoeff = true;
                    });
                OnPropertyChanged("CoefficientChangeable");
            }
        }
        public bool ShowCoefficientChangeable
        {
            get { return showCoefficientChangeable; }
            set
            {
                showCoefficientChangeable = value;
                OnPropertyChanged("ShowCoefficientChangeable");
            }
        }

        public bool SwitchToGetCoeff
        {
            get { return switchToGetCoeff; }
            set
            {
                switchToGetCoeff = value;
                OnPropertyChanged("SwitchToGetCoeff");
            }
        }
        public bool ShowSwitchToGetCoeff
        {
            get { return showSwitchToGetCoeff; }
            set
            {
                showSwitchToGetCoeff = value;
                OnPropertyChanged("ShowSwitchToGetCoeff");
            }
        }
        public int CategoryId { get; set; }
        public string Note
        {
            get => note;
            set
            {
                //bool r = value.ToCharArray().All(x => char.IsDigit(x));
                //value.ToCharArray().Select(x => x == ',');
                //note = r? value : note;
                note = value;
                OnPropertyChanged("Note");
            }
        }
        public ObservableCollection<SubjectCoeff> ListNames
        {
            get { return listNames; }
            set
            {
                listNames = value;
                OnPropertyChanged("ListNames");
            }
        }

        public string ListTitle { get; set; }
        public SubjectCoeff SelectedItemFromList
        {
            get { return selectedItemFromList; }
            set
            {
                selectedItemFromList = value;
                OnPropertyChanged("SelectedItemFromList");
                Device.BeginInvokeOnMainThread(async () =>
                {
                    ActualCoefficient = value.CoefficientNewValue;
                    SwitchToGetCoeff = false;
                    await Task.Delay(50);
                    SwitchToGetCoeff = true;
                });
                //ActualCoefficient = value.CoefficientNewValue;
                //SwitchToGetCoeff = false;
                //Task.Delay(50);
                //SwitchToGetCoeff = true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    public class SubSubjectCoeff : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    public class GroupedSubjectCoeff : ObservableCollection<SubjectCoeff>, INotifyPropertyChanged
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    public class SubjectCoeffList
    {
        public static List<SubjectCoeff> GetList(MajorDiscipline majorDiscipline)
        {
            List<SubjectCoeff> subjectCoeffs = null;
            if (majorDiscipline.CountryId == 1)
            {
                switch (majorDiscipline.Id)
                {
                    case 1:
                        subjectCoeffs = new List<SubjectCoeff>()
                        {
                            new SubjectCoeff()
                            {
                                Id = 1,
                                MajorDisciplineId = 1,
                                Name = "Français",
                                Type = "Écrit",
                                CategoryId = 1,
                                Coefficient = 2,
                                CoefficientChangeable = false
                            },
                            new SubjectCoeff()
                            {
                                Id = 2,
                                MajorDisciplineId = 1,
                                Name = "Histoire-Géo​",
                                Type = "Écrit",
                                CategoryId = 2,
                                Coefficient = 2,
                                CoefficientChangeable = false
                            },
                            new SubjectCoeff()
                            {
                                Id = 3,
                                MajorDisciplineId = 1,
                                Name = "Mathematics​",
                                Type = "Écrit",
                                CategoryId = 2,
                                Coefficient = 9,
                                CoefficientNewValue = 7,
                                CoefficientChangeable = true
                            },
                            new SubjectCoeff()
                            {
                                Id = 4,
                                MajorDisciplineId = 1,
                                Name = "EPS Compel.​",
                                Type = "Controle continu",
                                CategoryId = 2,
                                SwitchToGetCoeff = false,
                                Coefficient = 2,
                            },
                            new SubjectCoeff()
                            {
                                Id = 5,
                                MajorDisciplineId = 1,
                                ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Sciences de la vie et de la terre",
                                        Coefficient = 6,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Ecologie Agronomie & Territoires",
                                        Coefficient = 7,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Sciences de l’ingénieur",
                                        Coefficient = 6,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    }
                                },
                                CategoryId = 2,
                                CoefficientNewValue = 0,
                                CoefficientChangeable = true
                            },
                            new SubjectCoeff()
                            {
                                Id = 6,
                                MajorDisciplineId = 1,
                                ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 2,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 2,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 3,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    }
                                },
                                CategoryId = 3,
                                CoefficientNewValue = 0
                            },
                            new SubjectCoeff()
                            {
                                Id = 6,
                                MajorDisciplineId = 1,
                                ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 1,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 1,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 1,
                                        CoefficientNewValue = 0,
                                        CoefficientChangeable = true,
                                    }
                                },
                                CategoryId = 3,
                                CoefficientNewValue = 0
                            },
                        };
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
            }
            return subjectCoeffs;
        }
    }
}
