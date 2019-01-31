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
    ///The JuniorMicrosoftBusinessIntelligenceDeveloperPL recording.
    /// </summary>
    [TestModule("314d2b00-df94-43ba-8527-0389b9ab9cef", ModuleType.Recording, 1)]
    public partial class JuniorMicrosoftBusinessIntelligenceDeveloperPL : ITestModule
    {
        /// <summary>
        /// Holds an instance of the INKUBIT_Test___ContactFormRepository repository.
        /// </summary>
        public static INKUBIT_Test___ContactFormRepository repo = INKUBIT_Test___ContactFormRepository.Instance;

        static JuniorMicrosoftBusinessIntelligenceDeveloperPL instance = new JuniorMicrosoftBusinessIntelligenceDeveloperPL();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public JuniorMicrosoftBusinessIntelligenceDeveloperPL()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static JuniorMicrosoftBusinessIntelligenceDeveloperPL Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.inkubit.com/pl-pl/kariera/in%C5%BCynieria-oprogramowania/junior-microsoft-business-intelligence-developer/' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.inkubit.com/pl-pl/kariera/in%C5%BCynieria-oprogramowania/junior-microsoft-business-intelligence-developer/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='https://www.inkubit.com/media/74495/background.jpg') on item 'HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComMedia74671Back'.", repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComMedia74671BackInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComMedia74671BackInfo, "Src", "https://www.inkubit.com/media/74495/background.jpg");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Junior Microsoft Business Intelligence Developer') on item 'HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftBusinessIntelligenceD'.", repo.HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftBusinessIntelligenceDInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftBusinessIntelligenceDInfo, "InnerText", "Junior Microsoft Business Intelligence Developer");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='h1') on item 'HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftBusinessIntelligenceD'.", repo.HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftBusinessIntelligenceDInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftBusinessIntelligenceDInfo, "TagName", "h1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n                                    Prześlij aplikację\n                                ') on item 'HttpsWwwInkubitComEnUsCareers.DivTag4'.", repo.HttpsWwwInkubitComEnUsCareers.DivTag4Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.DivTag4Info, "InnerText", "\n                                    Prześlij aplikację\n                                ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pobierz jako PDF') on item 'HttpsWwwInkubitComEnUsCareers.PobierzJakoPDF'.", repo.HttpsWwwInkubitComEnUsCareers.PobierzJakoPDFInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.PobierzJakoPDFInfo, "InnerText", "Pobierz jako PDF");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://www.inkubit.com/media/74124/junior-microsoft-business-intelligence-developer.pdf') on item 'HttpsWwwInkubitComEnUsCareers.PobierzJakoPDF'.", repo.HttpsWwwInkubitComEnUsCareers.PobierzJakoPDFInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.PobierzJakoPDFInfo, "Href", "https://www.inkubit.com/media/74124/junior-microsoft-business-intelligence-developer.pdf");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HttpsWwwInkubitComEnUsCareers'.", repo.HttpsWwwInkubitComEnUsCareers.SelfInfo, new RecordItemIndex(7));
            Host.Current.CloseApplication(repo.HttpsWwwInkubitComEnUsCareers.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
