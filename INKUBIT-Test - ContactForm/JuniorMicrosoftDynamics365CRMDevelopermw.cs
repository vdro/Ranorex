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
    ///The JuniorMicrosoftDynamics365CRMDevelopermw recording.
    /// </summary>
    [TestModule("ae0dc901-8241-4a8f-9220-bff5540964f3", ModuleType.Recording, 1)]
    public partial class JuniorMicrosoftDynamics365CRMDevelopermw : ITestModule
    {
        /// <summary>
        /// Holds an instance of the INKUBIT_Test___ContactFormRepository repository.
        /// </summary>
        public static INKUBIT_Test___ContactFormRepository repo = INKUBIT_Test___ContactFormRepository.Instance;

        static JuniorMicrosoftDynamics365CRMDevelopermw instance = new JuniorMicrosoftDynamics365CRMDevelopermw();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public JuniorMicrosoftDynamics365CRMDevelopermw()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static JuniorMicrosoftDynamics365CRMDevelopermw Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.inkubit.com/de-de/karriere/development/junior-microsoft-dynamics-365-crm-developer-mw/' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.inkubit.com/de-de/karriere/development/junior-microsoft-dynamics-365-crm-developer-mw/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Junior Microsoft Dynamics 365 CRM Developer (m/w)') on item 'HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftDynamics365CRMDevelo'.", repo.HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftDynamics365CRMDeveloInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftDynamics365CRMDeveloInfo, "InnerText", "Junior Microsoft Dynamics 365 CRM Developer (m/w)");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='h1') on item 'HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftDynamics365CRMDevelo'.", repo.HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftDynamics365CRMDeveloInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.JuniorMicrosoftDynamics365CRMDeveloInfo, "TagName", "h1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n                                    Bewerbung einreichen\n                                ') on item 'HttpsWwwInkubitComEnUsCareers.DivTag4'.", repo.HttpsWwwInkubitComEnUsCareers.DivTag4Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.DivTag4Info, "InnerText", "\n                                    Bewerbung einreichen\n                                ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Als PDF herunterladen') on item 'HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladen3'.", repo.HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladen3Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladen3Info, "InnerText", "Als PDF herunterladen");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='https://www.inkubit.com/media/74682/junior-microsoft-dynamics-365-developer-deutsch.pdf') on item 'HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladen3'.", repo.HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladen3Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.AlsPDFHerunterladen3Info, "Href", "https://www.inkubit.com/media/74682/junior-microsoft-dynamics-365-developer-deutsch.pdf");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HttpsWwwInkubitComEnUsCareers'.", repo.HttpsWwwInkubitComEnUsCareers.SelfInfo, new RecordItemIndex(6));
            Host.Current.CloseApplication(repo.HttpsWwwInkubitComEnUsCareers.Self, 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
