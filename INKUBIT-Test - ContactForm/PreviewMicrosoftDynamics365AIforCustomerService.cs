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
    ///The PreviewMicrosoftDynamics365AIforCustomerService recording.
    /// </summary>
    [TestModule("15d189ce-a071-4ad7-9e93-bac8d0d9882b", ModuleType.Recording, 1)]
    public partial class PreviewMicrosoftDynamics365AIforCustomerService : ITestModule
    {
        /// <summary>
        /// Holds an instance of the INKUBIT_Test___ContactFormRepository repository.
        /// </summary>
        public static INKUBIT_Test___ContactFormRepository repo = INKUBIT_Test___ContactFormRepository.Instance;

        static PreviewMicrosoftDynamics365AIforCustomerService instance = new PreviewMicrosoftDynamics365AIforCustomerService();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PreviewMicrosoftDynamics365AIforCustomerService()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PreviewMicrosoftDynamics365AIforCustomerService Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.inkubit.com/blog/microsoft-dynamics-365/preview-microsoft-dynamics-365-ai-for-customer-service/' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.inkubit.com/blog/microsoft-dynamics-365/preview-microsoft-dynamics-365-ai-for-customer-service/", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Microsoft provides a preview environment for  AI for Customer Service. Especially for this purpose, Microsoft has created an  for requesting this preview environment. The requirement for testing the environment is an e-mail address that is linked to a Microsoft work account. Microsoft's AI offensive is now picking up speed and should keep the competition on their toes. Recently we wrote an article about . In this article you can read how to deploy the new AI features on your CRM instance.') on item 'HttpsWwwInkubitComEnUsCareers.MicrosoftProvidesAPreviewEnvironment'.", repo.HttpsWwwInkubitComEnUsCareers.MicrosoftProvidesAPreviewEnvironmentInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.MicrosoftProvidesAPreviewEnvironmentInfo, "InnerText", "Microsoft provides a preview environment for  AI for Customer Service. Especially for this purpose, Microsoft has created an  for requesting this preview environment. The requirement for testing the environment is an e-mail address that is linked to a Microsoft work account. Microsoft's AI offensive is now picking up speed and should keep the competition on their toes. Recently we wrote an article about . In this article you can read how to deploy the new AI features on your CRM instance.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Preview - Microsoft Dynamics 365 AI for Customer Service') on item 'HttpsWwwInkubitComEnUsCareers.PreviewMicrosoftDynamics365AIFor'.", repo.HttpsWwwInkubitComEnUsCareers.PreviewMicrosoftDynamics365AIForInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.PreviewMicrosoftDynamics365AIForInfo, "InnerText", "Preview - Microsoft Dynamics 365 AI for Customer Service");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='h1') on item 'HttpsWwwInkubitComEnUsCareers.PreviewMicrosoftDynamics365AIFor'.", repo.HttpsWwwInkubitComEnUsCareers.PreviewMicrosoftDynamics365AIForInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.PreviewMicrosoftDynamics365AIForInfo, "TagName", "h1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend' at 6;9.", repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontendInfo, new RecordItemIndex(4));
            repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend.Click("6;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend1' at Center.", repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend1Info, new RecordItemIndex(5));
            repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Microsoft stellt für Interessenten eine Preview-Umgebung für  AI for Customer Service zur Verfügung. Microsoft hat speziell hierfür eine eigene  erstellt, auf der die Preview-Umgebung angefordert werden kann. Voraussetzung um die Umgebung zu testen ist eine E-Mail Adresse, die mit einem Arbeitskonto von Microsoft verbunden ist. Microsofts AI Offensive nimmt mittlerweile richtig an Fahrt auf und soll die Konkurrenz auf Trab halten. Vor kurzem haben wir bereits einen Artikel über  verfasst. Dort können Sie nachlesen, wie Sie die neuen AI Features auf Ihrer CRM-Instanz bereitstellen.') on item 'HttpsWwwInkubitComEnUsCareers.MicrosoftStelltFuerInteressentenEine'.", repo.HttpsWwwInkubitComEnUsCareers.MicrosoftStelltFuerInteressentenEineInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.MicrosoftStelltFuerInteressentenEineInfo, "InnerText", "Microsoft stellt für Interessenten eine Preview-Umgebung für  AI for Customer Service zur Verfügung. Microsoft hat speziell hierfür eine eigene  erstellt, auf der die Preview-Umgebung angefordert werden kann. Voraussetzung um die Umgebung zu testen ist eine E-Mail Adresse, die mit einem Arbeitskonto von Microsoft verbunden ist. Microsofts AI Offensive nimmt mittlerweile richtig an Fahrt auf und soll die Konkurrenz auf Trab halten. Vor kurzem haben wir bereits einen Artikel über  verfasst. Dort können Sie nachlesen, wie Sie die neuen AI Features auf Ihrer CRM-Instanz bereitstellen.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwInkubitComEnUsCareers.Submenu' at 20;21.", repo.HttpsWwwInkubitComEnUsCareers.SubmenuInfo, new RecordItemIndex(7));
            repo.HttpsWwwInkubitComEnUsCareers.Submenu.Click("20;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend2' at 4;2.", repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend2Info, new RecordItemIndex(8));
            repo.HttpsWwwInkubitComEnUsCareers.HttpsWwwInkubitComAssetsFrontend2.Click("4;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Microsoft provides a preview environment for  AI for Customer Service. Especially for this purpose, Microsoft has created an  for requesting this preview environment. The requirement for testing the environment is an e-mail address that is linked to a Microsoft work account. Microsoft's AI offensive is now picking up speed and should keep the competition on their toes. Recently we wrote an article about . In this article you can read how to deploy the new AI features on your CRM instance.') on item 'HttpsWwwInkubitComEnUsCareers.MicrosoftProvidesAPreviewEnvironment'.", repo.HttpsWwwInkubitComEnUsCareers.MicrosoftProvidesAPreviewEnvironmentInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.HttpsWwwInkubitComEnUsCareers.MicrosoftProvidesAPreviewEnvironmentInfo, "InnerText", "Microsoft provides a preview environment for  AI for Customer Service. Especially for this purpose, Microsoft has created an  for requesting this preview environment. The requirement for testing the environment is an e-mail address that is linked to a Microsoft work account. Microsoft's AI offensive is now picking up speed and should keep the competition on their toes. Recently we wrote an article about . In this article you can read how to deploy the new AI features on your CRM instance.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'HttpsWwwInkubitComEnUsCareers'.", repo.HttpsWwwInkubitComEnUsCareers.SelfInfo, new RecordItemIndex(10));
            Host.Current.CloseApplication(repo.HttpsWwwInkubitComEnUsCareers.Self, 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
