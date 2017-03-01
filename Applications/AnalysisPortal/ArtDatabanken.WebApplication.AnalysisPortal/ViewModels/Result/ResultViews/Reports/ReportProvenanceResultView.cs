﻿using ArtDatabanken.Data;
using ArtDatabanken.WebApplication.AnalysisPortal.Managers.PageInfo;
using ArtDatabanken.WebApplication.AnalysisPortal.Result;
using ArtDatabanken.WebApplication.AnalysisPortal.Result.ResultCalculation.SpeciesObservationProvenanceResult;
using ArtDatabanken.WebApplication.AnalysisPortal.Utils.Helpers;

namespace ArtDatabanken.WebApplication.AnalysisPortal.ViewModels.Result.ResultViews.Reports
{
    public class ReportProvenanceResultView : ResultViewBase
    {
        public override string Title
        {
            get { return Resources.Resource.ResultViewProvenance; }
        }

        public override string Tooltip
        {
            get { return ""; }
        }

        public override ResultType ResultType
        {
            get { return ResultType.SpeciesObservationProvenanceReport; }
        }

        public override PageInfo StaticPageInfo
        {
            get { return PageInfoManager.GetPageInfo("Result", "ProvenanceReport"); }
        }

        public override bool IsActive
        {
            get { return SessionHandler.MySettings.Presentation.Report.IsActive; }
        }        
    }
}