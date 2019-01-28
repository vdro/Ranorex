﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace INKUBIT_Test___ContactForm
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SeniorBusinessIntelligenceConsultantforSAPSEProducts recording.
    /// </summary>
    [TestModule("5ad03571-4cf4-4793-8703-1f42d56d1e44", ModuleType.Recording, 1)]
    public partial class SeniorBusinessIntelligenceConsultantforSAPSEProducts : ITestModule
    {
        /// <summary>
        /// Holds an instance of the INKUBIT_Test___ContactFormRepository repository.
        /// </summary>
        public static INKUBIT_Test___ContactFormRepository repo = INKUBIT_Test___ContactFormRepository.Instance;

        static SeniorBusinessIntelligenceConsultantforSAPSEProducts instance = new SeniorBusinessIntelligenceConsultantforSAPSEProducts();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SeniorBusinessIntelligenceConsultantforSAPSEProducts()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SeniorBusinessIntelligenceConsultantforSAPSEProducts Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.inkubit.com/en-us/careers/consulting/senior-business-intelligence-consultant-for-sap-se-products/' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.inkubit.com/en-us/careers/consulting/senior-business-intelligence-consultant-for-sap-se-products/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Senior Business Intelligence Consultant for SAP SE Products') on item 'HttpsWwwInkubitComEnUsCareers.SeniorBusinessIntelligenceConsultant'.", repo.HttpsWwwInkubitComEnUsCareers.SeniorBusinessIntelligenceConsultantInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SeniorBusinessIntelligenceConsultantInfo, "InnerText", "Senior Business Intelligence Consultant for SAP SE Products");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='h1') on item 'HttpsWwwInkubitComEnUsCareers.SeniorBusinessIntelligenceConsultant'.", repo.HttpsWwwInkubitComEnUsCareers.SeniorBusinessIntelligenceConsultantInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SeniorBusinessIntelligenceConsultantInfo, "TagName", "h1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n                                    Submit Application\n                                ') on item 'HttpsWwwInkubitComEnUsCareers.DivTag'.", repo.HttpsWwwInkubitComEnUsCareers.DivTagInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.DivTagInfo, "InnerText", "\n                                    Submit Application\n                                ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Download as PDF') on item 'HttpsWwwInkubitComEnUsCareers.DownloadAsPDF'.", repo.HttpsWwwInkubitComEnUsCareers.DownloadAsPDFInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.DownloadAsPDFInfo, "InnerText", "Download as PDF");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://www.inkubit.com/media/74187/senior-bi-consultant-english.pdf') on item 'HttpsWwwInkubitComEnUsCareers.DownloadAsPDF'.", repo.HttpsWwwInkubitComEnUsCareers.DownloadAsPDFInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.DownloadAsPDFInfo, "Href", "https://www.inkubit.com/media/74187/senior-bi-consultant-english.pdf");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HttpsWwwInkubitComEnUsCareers'.", repo.HttpsWwwInkubitComEnUsCareers.SelfInfo, new RecordItemIndex(6));
            Host.Current.CloseApplication(repo.HttpsWwwInkubitComEnUsCareers.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
