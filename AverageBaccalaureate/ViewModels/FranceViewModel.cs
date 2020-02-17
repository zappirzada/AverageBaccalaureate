using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using AverageBaccalaureate.Models;

namespace AverageBaccalaureate.ViewModels
{
    public class FranceViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<GroupedSubjectCoeff> groupedSubjectCoeffs;
        GroupedSubjectCoeff anticipeesGroup;
        GroupedSubjectCoeff terminaleGroup;
        GroupedSubjectCoeff facultativesGroup;
        GroupedSubjectCoeff noteDeBacGroup;
        public FranceViewModel(MajorDiscipline SelectedMajor)
        {
            GroupedSubjectCoeffs = new ObservableCollection<GroupedSubjectCoeff>();
            anticipeesGroup = new GroupedSubjectCoeff() { LongName = "Épreuves Anticipées", ShortName = "A" };
            terminaleGroup = new GroupedSubjectCoeff() { LongName = "Épreuves De Terminale", ShortName = "T" };
            facultativesGroup = new GroupedSubjectCoeff() { LongName = "Épreuves Facultatives", ShortName = "F" };
            PopulateList(SelectedMajor);
            GroupedSubjectCoeffs.Add(anticipeesGroup);
            GroupedSubjectCoeffs.Add(terminaleGroup);
            GroupedSubjectCoeffs.Add(facultativesGroup);
        }
        public void PopulateList(MajorDiscipline majorDiscipline)
        {
            if (majorDiscipline.CountryId == 1)
            {
                switch (majorDiscipline.Id)
                {
                    case 1:
                        #region Case BAC_S
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 1,
                            Name = "Français",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 1,
                            Name = "Français",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 1,
                            Name = "TPE",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            Name = "Histoire-Géo​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            Name = "Mathematics​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientNewValue = 9,
                            CoefficientChangeable = true,
                            ShowCoefficientChangeable = true
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            Name = "Langue vivante 1​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            Name = "Langue vivante 2​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            Name = "Philosophie​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            Name = "EPS​​",
                            Type = "Contrôle continu",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 7,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            Name = "EPS compl.​",
                            Type = "Controle continu",
                            SwitchToGetCoeff = true,
                            ShowSwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 8,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            Name = "Physique-chimie​",
                            Type = "Écrit et pratique",
                            SwitchToGetCoeff = true,
                            Coefficient = 6,
                            CoefficientNewValue = 8,
                            CoefficientChangeable = true,
                            ShowCoefficientChangeable = true
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 9,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Sciences de la vie et de la terre",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Ecologie Agronomie & Territoires",
                                        Coefficient = 0,
                                        CoefficientNewValue = 7
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Sciences de l’ingénieur",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    }
                                },
                            ListTitle = "Spécialité 1",
                            ShowCourseName = false,
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientNewValue = 6,
                            CoefficientChangeable = false,
                            //ShowCoefficientChangeable = true
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 10,
                            CategoryId = 2,
                            MajorDisciplineId = 1,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Informatique & Sciences du Num.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Ecologie Agron. & Territoires",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    }
                                },
                            ListTitle = "Spécialité 2",
                            ShowCourseName = false,
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientNewValue = 2,
                            CoefficientChangeable = false,
                            //ShowCoefficientChangeable = true
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 3,
                            MajorDisciplineId = 1,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 3
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Grec.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 3
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Hippologie & Equitation",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Pratiques Soc. & Cult.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 1",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 3,
                            MajorDisciplineId = 1,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Grec.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Hippologie & Equitation",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Pratiques Soc. & Cult.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 2",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 2:
                        #region Case BAC_ES
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "Français",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "Français",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "Sciences",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 2,
                            Name = "TPE",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            Name = "Histoire-Géo​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            Name = "Mathematics​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientNewValue = 7,
                            CoefficientChangeable = true,
                            ShowCoefficientChangeable = true
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            Name = "SES​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientNewValue = 9,
                            CoefficientChangeable = true,
                            ShowCoefficientChangeable = true
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            Name = "Langue vivante 1​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            Name = "Langue vivante 2​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            Name = "Philosophie​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 7,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            Name = "EPS​​",
                            Type = "Contrôle continu",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 8,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            Name = "EPS compl.​",
                            Type = "Controle continu",
                            SwitchToGetCoeff = true,
                            ShowSwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 9,
                            CategoryId = 2,
                            MajorDisciplineId = 2,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Économie approfondie",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Sciences sociales et politiquess",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    }
                                },
                            ListTitle = "Spécialité 1",
                            ShowCourseName = false,
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientNewValue = 2,
                            CoefficientChangeable = false,
                            //ShowCoefficientChangeable = true
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 3,
                            MajorDisciplineId = 2,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 3
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Grec.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 3
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 1",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 3,
                            MajorDisciplineId = 2,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Grec.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 2",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 3:
                        #region Case BAC_L
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 3,
                            Name = "Français",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 3,
                            Name = "Français",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 3,
                            Name = "Sciences",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 1,
                            MajorDisciplineId = 3,
                            Name = "TPE",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            Name = "Histoire-Géo​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            Name = "Langue vivante 1​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientNewValue = 8,
                            CoefficientChangeable = true,
                            ShowCoefficientChangeable = true
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            Name = "Langue vivante 2​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientNewValue = 8,
                            CoefficientChangeable = true,
                            ShowCoefficientChangeable = true
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            Name = "Philosophie​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            Name = "EPS​​",
                            Type = "Contrôle continu",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            Name = "EPS compl.​",
                            Type = "Controle continu",
                            SwitchToGetCoeff = true,
                            ShowSwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 7,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            Name = "Littérature étrangère​​",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 1,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 8,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            Name = "Littérature​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 9,
                            CategoryId = 2,
                            MajorDisciplineId = 3,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Mathématiques",
                                        Coefficient = 0,
                                        CoefficientNewValue = 4
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 4
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 4
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Grec.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 4
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Droits & Grands Enjeux",
                                        Coefficient = 0,
                                        CoefficientNewValue = 4
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts Plastiques",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Cinéma Audio-Visuel",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Histoire des Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Théâtre",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Danse",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts du Cirque",
                                        Coefficient = 0,
                                        CoefficientNewValue = 6
                                    }
                                },
                            ListTitle = "Spécialité 1",
                            ShowCourseName = false,
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientNewValue = 6,
                            CoefficientChangeable = false,
                            //ShowCoefficientChangeable = true
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 3,
                            MajorDisciplineId = 3,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 3
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Grec.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 3
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 1",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 3,
                            MajorDisciplineId = 3,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Latin.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Grec.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 2",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 4:
                        #region Case BAC_ST2S
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 4,
                            Name = "Français",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 4,
                            Name = "Français",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 4,
                            Name = "Activités interdisciplinaires",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Histoire-Géo​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Mathematics​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Langue vivante 1​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Langue vivante 2​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Philosophie​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "EPS​​",
                            Type = "Contrôle continu",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 7,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "EPS compl.​",
                            Type = "Controle continu",
                            SwitchToGetCoeff = true,
                            ShowSwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 8,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Biologie & physiopathologies humaines​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 9,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Sciences et techniques sanitaires et sociales​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 10,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Projet technologique ​​",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 7,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 11,
                            CategoryId = 2,
                            MajorDisciplineId = 4,
                            Name = "Sciences physiques et chimiques ​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 3,
                            MajorDisciplineId = 4,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 1",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 3,
                            MajorDisciplineId = 4,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 2",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 5:
                        #region Case BAC_STD2A
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 5,
                            Name = "Français",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 5,
                            Name = "Français",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 5,
                            Name = "Histoire-Géo",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "Mathematics​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "Langue vivante 1​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "Langue vivante 2​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "Philosophie​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "EPS​​",
                            Type = "Contrôle continu",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "EPS compl.​",
                            Type = "Controle continu",
                            SwitchToGetCoeff = true,
                            ShowSwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 7,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "Physique-chimie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 8,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "Analyse méthodique en design et arts appliqués​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 6,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 9,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "Projet en design et arts appliqués​",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 16,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 10,
                            CategoryId = 2,
                            MajorDisciplineId = 5,
                            Name = "Design et arts appliqués en LV1​",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 3,
                            MajorDisciplineId = 5,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 1",
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 3,
                            MajorDisciplineId = 5,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 2",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 6:
                        #region Case BAC_STI2D
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Français",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Français",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 6,
                            Name = "Histoire-Géo",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "Mathematics​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false,
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "Langue vivante 1​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "Langue vivante 2​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "Philosophie​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "EPS​​",
                            Type = "Contrôle continu",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "EPS compl.​",
                            Type = "Controle continu",
                            SwitchToGetCoeff = true,
                            ShowSwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 7,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "Physique-chimie​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 4,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 8,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "Enseignements technologiques transversaux​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 8,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 9,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            Name = "Enseignement technologique en LV​",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 10,
                            CategoryId = 2,
                            MajorDisciplineId = 6,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Architecture & Construction",
                                        Coefficient = 0,
                                        CoefficientNewValue = 12
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Energies & Environnement",
                                        Coefficient = 0,
                                        CoefficientNewValue = 12
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Innov. Tech. & Eco-Concep.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 12
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Syst. d’Infor. et Numérique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 12
                                    }
                                },
                            ListTitle = "Spécialité 1",
                            ShowCourseName = false,
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientNewValue = 6,
                            CoefficientChangeable = false,
                            //ShowCoefficientChangeable = true
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 3,
                            MajorDisciplineId = 6,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 1",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 3,
                            MajorDisciplineId = 6,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue vivante 3.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 2",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        #endregion
                        break;
                    case 7:
                        #region Case BAC_STMG
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 1,
                            MajorDisciplineId = 7,
                            Name = "Français",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 1,
                            MajorDisciplineId = 7,
                            Name = "Français",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        anticipeesGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 1,
                            MajorDisciplineId = 7,
                            Name = "Études de gestion",
                            Type = "Oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "Histoire-Géo​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "Mathematics​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 3,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "Langue vivante 1​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 3,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 4,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "Langue vivante 2​​",
                            Type = "Écrit et oral",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 5,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "Philosophie​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 6,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "EPS​​",
                            Type = "Contrôle continu",
                            SwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 7,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "EPS compl.​",
                            Type = "Controle continu",
                            SwitchToGetCoeff = true,
                            ShowSwitchToGetCoeff = true,
                            Coefficient = 2,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 8,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "Economie-droit​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 9,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            Name = "Management des organisations​​",
                            Type = "Écrit",
                            SwitchToGetCoeff = true,
                            Coefficient = 5,
                            CoefficientChangeable = false
                        });
                        terminaleGroup.Add(new SubjectCoeff()
                        {
                            Id = 10,
                            CategoryId = 2,
                            MajorDisciplineId = 7,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Gestion & Finance",
                                        Coefficient = 0,
                                        CoefficientNewValue = 12
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Marketing",
                                        Coefficient = 0,
                                        CoefficientNewValue = 12
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Ress. Humai. & Comm",
                                        Coefficient = 0,
                                        CoefficientNewValue = 12
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Sys. Infor. de Gestion",
                                        Coefficient = 0,
                                        CoefficientNewValue = 12
                                    }
                                },
                            ListTitle = "Spécialité 1",
                            ShowCourseName = false,
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientNewValue = 6,
                            CoefficientChangeable = false,
                            //ShowCoefficientChangeable = true
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 1,
                            CategoryId = 3,
                            MajorDisciplineId = 7,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 2
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 1",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
                            CoefficientChangeable = false
                        });
                        facultativesGroup.Add(new SubjectCoeff()
                        {
                            Id = 2,
                            CategoryId = 3,
                            MajorDisciplineId = 7,
                            ListNames = new ObservableCollection<SubjectCoeff>()
                                {
                                    new SubjectCoeff
                                    {
                                        Name = "Langue des signes.",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "EPS (option)",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Arts",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    },
                                    new SubjectCoeff
                                    {
                                        Name = "Musique",
                                        Coefficient = 0,
                                        CoefficientNewValue = 1
                                    }
                                },
                            ShowCourseName = false,
                            ListTitle = "Option 2",
                            SwitchToGetCoeff = true,
                            Coefficient = 0,
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
