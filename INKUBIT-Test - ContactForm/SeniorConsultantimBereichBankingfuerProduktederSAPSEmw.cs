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
    ///The SeniorConsultantimBereichBankingfuerProduktederSAPSEmw recording.
    /// </summary>
    [TestModule("9bc6de73-2562-4d5f-a082-041a09a07e3a", ModuleType.Recording, 1)]
    public partial class SeniorConsultantimBereichBankingfuerProduktederSAPSEmw : ITestModule
    {
        /// <summary>
        /// Holds an instance of the INKUBIT_Test___ContactFormRepository repository.
        /// </summary>
        public static INKUBIT_Test___ContactFormRepository repo = INKUBIT_Test___ContactFormRepository.Instance;

        static SeniorConsultantimBereichBankingfuerProduktederSAPSEmw instance = new SeniorConsultantimBereichBankingfuerProduktederSAPSEmw();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SeniorConsultantimBereichBankingfuerProduktederSAPSEmw()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SeniorConsultantimBereichBankingfuerProduktederSAPSEmw Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.inkubit.com/de-de/karriere/consulting/senior-consultant-im-bereich-banking-fuer-produkte-der-sap-se-mw/' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.inkubit.com/de-de/karriere/consulting/senior-consultant-im-bereich-banking-fuer-produkte-der-sap-se-mw/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Senior Consultant im Bereich Banking für Produkte der SAP SE (m/w)') on item 'HttpsWwwInkubitComEnUsCareers.SeniorConsultantImBereichBusinessIn'.", repo.HttpsWwwInkubitComEnUsCareers.SeniorConsultantImBereichBusinessInInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SeniorConsultantImBereichBusinessInInfo, "InnerText", "Senior Consultant im Bereich Banking für Produkte der SAP SE (m/w)");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='h1') on item 'HttpsWwwInkubitComEnUsCareers.SeniorConsultantImBereichBusinessIn'.", repo.HttpsWwwInkubitComEnUsCareers.SeniorConsultantImBereichBusinessInInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.SeniorConsultantImBereichBusinessInInfo, "TagName", "h1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='https://www.inkubit.com/media/74517/background.jpg') on item 'HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComMedia74506Back'.", repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComMedia74506BackInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComMedia74506BackInfo, "Src", "https://www.inkubit.com/media/74517/background.jpg");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n                                    Bewerbung einreichen\n                                ') on item 'HttpsWwwInkubitComEnUsCareers.DivTag1'.", repo.HttpsWwwInkubitComEnUsCareers.DivTag1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.DivTag1Info, "InnerText", "\n                                    Bewerbung einreichen\n                                ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Als PDF herunterladen') on item 'HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladen'.", repo.HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladenInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladenInfo, "InnerText", "Als PDF herunterladen");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://www.inkubit.com/media/74223/senior-banking-consultat-m-w-deutsch.pdf') on item 'HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladen'.", repo.HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladenInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladenInfo, "Href", "https://www.inkubit.com/media/74223/senior-banking-consultat-m-w-deutsch.pdf");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HttpsWwwInkubitComEnUsCareers'.", repo.HttpsWwwInkubitComEnUsCareers.SelfInfo, new RecordItemIndex(7));
            Host.Current.CloseApplication(repo.HttpsWwwInkubitComEnUsCareers.Self, 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
