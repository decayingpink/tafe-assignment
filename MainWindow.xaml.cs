using System.IO;
using System.Windows;

namespace tafethingy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
	// this is a comment to test the vsc
        static String datafilename = "Database.txt";
        static String markeddatafilename = "markedDatabase.txt";
        static String[] data = File.ReadAllLines(datafilename);
        static String[] markeddata = File.ReadAllLines(markeddatafilename);

        static String[] assessmentdata = { // name, duedate, subject,type, grade
            data[0], data[1], data[2], data[3], data[4],
             data[5], data[6], data[7],data[8], data[9],
             markeddata[0], markeddata[1], markeddata[2], markeddata[3], markeddata[4],
             markeddata[5], markeddata[6], markeddata[7],markeddata[8], markeddata[9]};

        bool[] dataslottaken = { (assessmentdata[0] != "N/A"), (assessmentdata[5] != "N/A"), (assessmentdata[10] != "N/A"), (assessmentdata[15] != "N/A") };

        bool assessments_dropdown_opened = false;
        bool filter_dropdown_opened = false;
        int selected_filter_type = 0;
        int selected_assessment = 0;

        int duedays = 1;
        int duemonths = 1;
        int dueyears = 2026;

        private void Assessments_Dropdown_Click(object sender, RoutedEventArgs e)
        {



            if (!assessments_dropdown_opened)
            {
                if (assessmentdata[0] != "N/A" && (assessmentdata[selected_filter_type] == filter_input_text.Text || filter_input_text.Text == ""))
                {
                    Assessments_Dropdown_option1.Visibility = Visibility.Visible;
                    Assessments_Dropdown_option1.Content = assessmentdata[0];
                }
                if (assessmentdata[5] != "N/A" && (assessmentdata[selected_filter_type + 5] == filter_input_text.Text || filter_input_text.Text == ""))
                {
                    Assessments_Dropdown_option2.Visibility = Visibility.Visible;
                    Assessments_Dropdown_option2.Content = assessmentdata[5];
                }
                if (assessmentdata[10] != "N/A" && (assessmentdata[selected_filter_type + 10] == filter_input_text.Text || filter_input_text.Text == ""))
                {
                    Assessments_Dropdown_option3.Visibility = Visibility.Visible;
                    Assessments_Dropdown_option3.Content = assessmentdata[10];
                }
                if (assessmentdata[15] != "N/A" && (assessmentdata[selected_filter_type + 15] == filter_input_text.Text || filter_input_text.Text == ""))
                {
                    Assessments_Dropdown_option4.Visibility = Visibility.Visible;
                    Assessments_Dropdown_option4.Content = assessmentdata[15];
                }

            }
            else
            {
                Assessments_Dropdown_option1.Visibility = Visibility.Hidden;
                Assessments_Dropdown_option2.Visibility = Visibility.Hidden;
                Assessments_Dropdown_option3.Visibility = Visibility.Hidden;
                Assessments_Dropdown_option4.Visibility = Visibility.Hidden;

            }
            mark_S.Visibility = Visibility.Hidden;
            mark_NYS.Visibility = Visibility.Hidden;

            Assessment_Name.Text = "";
            duedate_days.Text = "";
            duedate_months.Text = "";
            duedate_years.Text = "";
            Assessment_subject.Text = "";
            Assessment_type.Text = "";
            grade_text.Text = "";

            assessments_dropdown_opened = !assessments_dropdown_opened;

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(datafilename, // file is at C:\Users\30128539\source\repos\CsharpThingy\CsharpThingy\bin\Debug\net8.0-windows
                                assessmentdata[0] + "\n" + assessmentdata[1] + "\n" + assessmentdata[2] + "\n" + assessmentdata[3] + "\n" + assessmentdata[4] + "\n" +
                                assessmentdata[5] + "\n" + assessmentdata[6] + "\n" + assessmentdata[7] + "\n" + assessmentdata[8] + "\n" + assessmentdata[9]
                                );

            File.WriteAllText(markeddatafilename,// file is at C:\Users\30128539\source\repos\CsharpThingy\CsharpThingy\bin\Debug\net8.0-windows
                                assessmentdata[10] + "\n" + assessmentdata[11] + "\n" + assessmentdata[12] + "\n" + assessmentdata[13] + "\n" + assessmentdata[14] + "\n" +
                                assessmentdata[15] + "\n" + assessmentdata[16] + "\n" + assessmentdata[17] + "\n" + assessmentdata[18] + "\n" + assessmentdata[19]
                                );

        }

        private void Assessments_Dropdown_option1_Click(object sender, RoutedEventArgs e)
        {

            selected_assessment = 0;
            Assessment_Name.Text = assessmentdata[0];
            string test1 = assessmentdata[1];
            duedate_days.Text = test1.Substring(0,2);
            duedate_months.Text = test1.Substring(1,3);
            duedate_years.Text = test1.Substring(0,3);
            Assessment_subject.Text = assessmentdata[2];
            Assessment_type.Text = assessmentdata[3];
            grade_text.Text = assessmentdata[4];
        }

        private void Assessments_Dropdown_option2_Click(object sender, RoutedEventArgs e)
        {
            selected_assessment = 1;
            Assessment_Name.Text = assessmentdata[5];
            duedate_days.Text = assessmentdata[6].Substring(0, 1);
            duedate_months.Text = assessmentdata[6].Substring(2, 3);
            duedate_years.Text = assessmentdata[6].Substring(4, 7);
            Assessment_subject.Text = assessmentdata[7];
            Assessment_type.Text = assessmentdata[8];
            grade_text.Text = assessmentdata[9];

        }

        private void Assessments_Dropdown_option3_Click(object sender, RoutedEventArgs e)
        {
            selected_assessment = 2;
            Assessment_Name.Text = assessmentdata[10];
            duedate_days.Text = assessmentdata[11].Substring(0, 1);
            duedate_months.Text = assessmentdata[11].Substring(2, 3);
            duedate_years.Text = assessmentdata[11].Substring(4, 7);
            Assessment_subject.Text = assessmentdata[12];
            Assessment_type.Text = assessmentdata[13];
            grade_text.Text = assessmentdata[14];
        }

        private void Assessments_Dropdown_option4_Click(object sender, RoutedEventArgs e)
        {
            selected_assessment = 3;
            Assessment_Name.Text = assessmentdata[15];
            duedate_days.Text = assessmentdata[16].Substring(0, 1);
            duedate_months.Text = assessmentdata[16].Substring(2, 3);
            duedate_years.Text = assessmentdata[16].Substring(4, 7);
            Assessment_subject.Text = assessmentdata[17];
            Assessment_type.Text = assessmentdata[18];
            grade_text.Text = assessmentdata[19];
        }

        private void Assessments_add_Click(object sender, RoutedEventArgs e)
        {

            if (dataslottaken[0] && dataslottaken[1])
            {
            }
            else
            {
                if (!dataslottaken[0])
                {
                    selected_assessment = 0;
                }
                else if (!dataslottaken[1])
                {
                    selected_assessment = 1;
                }


                Assessment_Name.IsReadOnly = false;
                duedate_days_inc.Visibility = Visibility.Visible;
                duedate_months_inc.Visibility = Visibility.Visible;
                duedate_years_inc.Visibility = Visibility.Visible;
                Assessment_subject.IsReadOnly = false;
                Assessment_type.IsReadOnly = false;



                Assessment_Name.Text = "enter text";
                
                Assessment_subject.Text = "enter text";
                Assessment_type.Text = "enter text";
                grade_text.Text = "grade: ";
            }
        }

        private void save_assessment_Click(object sender, RoutedEventArgs e)
        {
            Assessment_Name.IsReadOnly = true;
            duedate_days_inc.Visibility = Visibility.Hidden;
            duedate_months_inc.Visibility = Visibility.Hidden;
            duedate_years_inc.Visibility = Visibility.Hidden;
            Assessment_subject.IsReadOnly = true;
            Assessment_type.IsReadOnly = true;

            mark_NYS.Visibility = Visibility.Hidden;
            mark_S.Visibility = Visibility.Hidden;
            dataslottaken[selected_assessment] = true;

            if ((grade_text.Text != "grade: ") && (selected_assessment == 0 || selected_assessment == 1))
            {
                if (!dataslottaken[2])
                {
                    assessmentdata[0 + selected_assessment * 5] = "N/A";
                    assessmentdata[1 + selected_assessment * 5] = "N/A";
                    assessmentdata[2 + selected_assessment * 5] = "N/A";
                    assessmentdata[3 + selected_assessment * 5] = "N/A";
                    assessmentdata[4 + selected_assessment * 5] = "N/A";
                    selected_assessment = 2;
                }
                else if (!dataslottaken[3])
                {

                    assessmentdata[0 + selected_assessment * 5] = "N/A";
                    assessmentdata[1 + selected_assessment * 5] = "N/A";
                    assessmentdata[2 + selected_assessment * 5] = "N/A";
                    assessmentdata[3 + selected_assessment * 5] = "N/A";
                    assessmentdata[4 + selected_assessment * 5] = "N/A";
                    selected_assessment = 3;
                }
            }

            assessmentdata[0 + selected_assessment * 5] = Assessment_Name.Text;
            assessmentdata[1 + selected_assessment * 5] = duedate_days.Text + duedate_months.Text + duedate_years.Text;
            assessmentdata[2 + selected_assessment * 5] = Assessment_subject.Text;
            assessmentdata[3 + selected_assessment * 5] = Assessment_type.Text;
            assessmentdata[4 + selected_assessment * 5] = grade_text.Text;

            dataslottaken[selected_assessment] = true;

            Assessment_Name.Text = "";

            duedate_days.Text = "";
            duedate_months.Text = "";
            duedate_years.Text = "";

            Assessment_subject.Text = "";
            Assessment_type.Text = "";
            grade_text.Text = "";
        }

        private void delete_assessment_Click(object sender, RoutedEventArgs e)
        {

            if (assessmentdata[0] == Assessment_Name.Text)
            {
                assessmentdata[0] = "N/A";
                assessmentdata[1] = "N/A";
                assessmentdata[2] = "N/A";
                assessmentdata[3] = "N/A";
                assessmentdata[4] = "N/A";
            }
            else if (assessmentdata[5] == Assessment_Name.Text)
            {
                assessmentdata[5] = "N/A";
                assessmentdata[6] = "N/A";
                assessmentdata[7] = "N/A";
                assessmentdata[8] = "N/A";
                assessmentdata[9] = "N/A";
            }
            else if (assessmentdata[10] == Assessment_Name.Text)
            {
                assessmentdata[10] = "N/A";
                assessmentdata[11] = "N/A";
                assessmentdata[12] = "N/A";
                assessmentdata[13] = "N/A";
                assessmentdata[14] = "N/A";
            }
            else if (assessmentdata[15] == Assessment_Name.Text)
            {
                assessmentdata[15] = "N/A";
                assessmentdata[16] = "N/A";
                assessmentdata[17] = "N/A";
                assessmentdata[18] = "N/A";
                assessmentdata[19] = "N/A";
            }
            dataslottaken[0] = (assessmentdata[0] != "N/A");
            dataslottaken[1] = (assessmentdata[5] != "N/A");
            dataslottaken[2] = (assessmentdata[10] != "N/A");
            dataslottaken[3] = (assessmentdata[15] != "N/A");

        }

        private void filterdropdown_Click(object sender, RoutedEventArgs e)
        {
            if (!filter_dropdown_opened)
            {
                filter_name.Visibility = Visibility.Visible;
                filter_grade.Visibility = Visibility.Visible;
                filter_subject.Visibility = Visibility.Visible;
                filter_type.Visibility = Visibility.Visible;

            }
            else
            {
                filter_input_text.Visibility = Visibility.Hidden;
                filter_input_text.IsReadOnly = true;

                filter_name.Visibility = Visibility.Hidden;
                filter_grade.Visibility = Visibility.Hidden;
                filter_subject.Visibility = Visibility.Hidden;
                filter_type.Visibility = Visibility.Hidden;
            }
            filter_dropdown_opened = !filter_dropdown_opened;
        }

        private void filter_name_Click(object sender, RoutedEventArgs e)
        {
            selected_filter_type = 0;
            filter_input_text.IsReadOnly = false;

            filter_input_text.Visibility = Visibility.Visible;
        }

        private void filter_grade_Click(object sender, RoutedEventArgs e)
        {
            selected_filter_type = 4;
            filter_input_text.IsReadOnly = false;

            filter_input_text.Visibility = Visibility.Visible;
        }

        private void filter_subject_Click(object sender, RoutedEventArgs e)
        {
            selected_filter_type = 2;
            filter_input_text.IsReadOnly = false;

            filter_input_text.Visibility = Visibility.Visible;
        }

        private void filter_type_Click(object sender, RoutedEventArgs e)
        {
            selected_filter_type = 3;
            filter_input_text.IsReadOnly = false;

            filter_input_text.Visibility = Visibility.Visible;
        }

        private void filter_duedate_Click(object sender, RoutedEventArgs e)
        {
            selected_filter_type = 1;
            filter_input_text.IsReadOnly = false;

            filter_input_text.Visibility = Visibility.Visible;
        }

        private void mark_NYS_Click(object sender, RoutedEventArgs e)
        {

            if ((!dataslottaken[2] || !dataslottaken[3]) || selected_assessment == 2 || selected_assessment == 3)
            {
                grade_text.Text = "grade:NYS";
            }
        }

        private void mark_S_Click(object sender, RoutedEventArgs e)
        {

            if ((!dataslottaken[2] || !dataslottaken[3]) || selected_assessment == 2 || selected_assessment == 3)
            {
                grade_text.Text = "grade: S";
            }
        }

        private void edit_assessment_Click(object sender, RoutedEventArgs e)
        {



            Assessment_Name.IsReadOnly = false;
            duedate_days_inc.Visibility = Visibility.Visible;
            duedate_months_inc.Visibility = Visibility.Visible;
            duedate_years_inc.Visibility = Visibility.Visible;
            Assessment_subject.IsReadOnly = false;
            Assessment_type.IsReadOnly = false;

            mark_NYS.Visibility = Visibility.Visible;
            mark_S.Visibility = Visibility.Visible;



        }

        private void duedate_days_inc_Click(object sender, RoutedEventArgs e)
        {
            duedays = (duedays % 31) + 1;
            if (duedays >= 10){
                duedate_days.Text = "" + duedays;
            }
            else{
                duedate_days.Text = "0" + duedays;
            }
        }
        private void duedate_months_inc_Click(object sender, RoutedEventArgs e)
        {
            duemonths = (duemonths % 12) + 1;
            if (duemonths >= 10)
            {
                duedate_months.Text = "" + duemonths;
            }
            else
            {
                duedate_months.Text = "0" + duemonths;
            }
            
        }

        private void duedate_years_inc_Click(object sender, RoutedEventArgs e)
        {
            dueyears = ((dueyears - 2025) % 10) + 2026;
            duedate_years.Text = dueyears + "";
        }
    }
}