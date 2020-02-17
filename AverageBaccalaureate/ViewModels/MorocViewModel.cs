using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using AverageBaccalaureate.Models;

namespace AverageBaccalaureate.ViewModels
{
    public class MorocViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<GroupedSubjectCoeff> groupedSubjectCoeffs;
        private GroupedSubjectCoeff noteDeBacGroup;
        private GroupedSubjectCoeff moyenneDirectGroup;

        public MorocViewModel(MajorDiscipline SelectedMajor)
        {
            GroupedSubjectCoeffs = new ObservableCollection<GroupedSubjectCoeff>();
            noteDeBacGroup = new GroupedSubjectCoeff() { LongName = "Saisir votre Note de BAC", ShortName = "S" };
            PopulateList(SelectedMajor);
            GroupedSubjectCoeffs.Add(noteDeBacGroup);
        }
        public MorocViewModel()
        {
            try
            {
                GroupedSubjectCoeffs = new ObservableCollection<GroupedSubjectCoeff>();
                moyenneDirectGroup = new GroupedSubjectCoeff() { LongName = "Calcul Moyenne Direct", ShortName = "C" };
                moyenneDirectGroup.Add(new SubjectCoeff()
                {
                    Id = 1,
                    CategoryId = 1,
                    MajorDisciplineId = 0,
                    Name = "Moyenne Exam Régional​",
                    SwitchToGetCoeff = true,
                    Coefficient = 0.25,
                    CoefficientChangeable = false
                });
                moyenneDirectGroup.Add(new SubjectCoeff()
                {
                    Id = 2,
                    CategoryId = 1,
                    MajorDisciplineId = 0,
                    Name = "Moyenne Note Classe​",
                    SwitchToGetCoeff = true,
                    Coefficient = 0.25,
                    CoefficientChangeable = false
                });
                moyenneDirectGroup.Add(new SubjectCoeff()
                {
                    Id = 3,
                    CategoryId = 1,
                    MajorDisciplineId = 1,
                    Name = "Moyenne Exam BAC​",
                    SwitchToGetCoeff = true,
                    Coefficient = 0.5,
                    CoefficientChangeable = false
                });
                GroupedSubjectCoeffs.Add(moyenneDirectGroup);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }
        public void PopulateList(MajorDiscipline majorDiscipline)
        {
            if (majorDiscipline.CountryId == 2)
            {
                switch (majorDiscipline.Id)
                {
                    case 1:
                        #region Case اللغة العربية
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 1,
                            Name = "علوم اللغة​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 1,
                            Name = "الأدب​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 1,
                            Name = "التفسير والحديث​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 1,
                            Name = "اللغة الأجنبية الثانية​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 1,
                            Name = "الفلسفة",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 2:
                        #region Case العلوم الشرعية
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "الأدب​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "التفسير والحديث​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "الفقه والأصول",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "اللغة الأجنبية الثانية",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "الفلسفة",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 3:
                        #region Case الٱداب
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 3,
                            Name = "اللغة العربية​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 3,
                            Name = "اللغة الأجنبية",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 3,
                            Name = "التاريخ والجغرافيا",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 3,
                            Name = "الفلسفة",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 4:
                        #region Case العلوم الإنسانية
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 4,
                            Name = "اللغة العربية",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 4,
                            Name = "اللغة الأجنبية​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 4,
                            Name = "التاريخ و الجغرافيا",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 4,
                            Name = "الفلسفة​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 5:
                        #region Case Sciences Physiques
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 5,
                            Name = "Mathématiques​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 5,
                            Name = "Physiques/Chimie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 5,
                            Name = "Sciences de la vie et de la terre​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 5,
                            Name = "Philosophie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 5,
                            Name = "Langue étrangère",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 6:
                        #region Case Sciences Agronomiques
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Mathématiques​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Physiques/Chimie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Sciences de la vie et de la terre​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Philosophie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Langue étrangère",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Sciences des Plantes et Animaux",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 7:
                        #region Case Sciences Mathématiques
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 7,
                            Name = "Mathématiques​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 9,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 7,
                            Name = "Physiques/Chimie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 7,
                            Name = "SVI ou SI​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 7,
                            Name = "Philosophie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 7,
                            Name = "Langue étrangère",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 8:
                        #region Case Sciences Economiques
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 8,
                            Name = "Mathématiques​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 8,
                            Name = "Comptabilité et mathématiques financières​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 8,
                            Name = "Economie générale et statistiques​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 6,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 8,
                            Name = "Economie et organisation des entreprises​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 8,
                            Name = "Philosophie",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 1,
                            MajorDisciplineId = 8,
                            Name = "Langue étrangère",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 9:
                        #region Case Gestion et Comptabilité
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 9,
                            Name = "Mathématiques​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 9,
                            Name = "Comptabilité et mathématiques financières​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 6,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 9,
                            Name = "Economie générale et statistiques​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 9,
                            Name = "Economie et organisation des entreprises​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 6,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 9,
                            Name = "Philosophie",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 1,
                            MajorDisciplineId = 9,
                            Name = "Langue étrangère",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 10:
                        #region Case Sciences et Technologies
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 10,
                            Name = "Mathématiques​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 10,
                            Name = "Physiques/Chimie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 10,
                            Name = "Sciences de l’ingénieur​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 8,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 10,
                            Name = "Philosophie",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 10,
                            Name = "Langue étrangère",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 11:
                        #region Case Arts Appliqués
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 11,
                            Name = "Arts et conception de la communication​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 8,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 11,
                            Name = "Art conception de l’environnement​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 11,
                            Name = "Art et conception des produits​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 11,
                            Name = "Philosophie",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 11,
                            Name = "Langue étrangère",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 12:
                        #region SWT
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 12,
                            Name = "Mathématiques",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 12,
                            Name = "Physiques/Chimie",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 12,
                            Name = "Sciences de la vie et de la terre​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 12,
                            Name = "Philosophie",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        noteDeBacGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 1,
                            MajorDisciplineId = 12,
                            Name = "Langue étrangère",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    default:
                        break;
                }
            }
        }
        public ObservableCollection<GroupedSubjectCoeff> GroupedSubjectCoeffs
        {
            get { return groupedSubjectCoeffs; }
            set
            {
                groupedSubjectCoeffs = value;
                OnPropertyChanged("GroupedSubjectCoeffs");
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
}
