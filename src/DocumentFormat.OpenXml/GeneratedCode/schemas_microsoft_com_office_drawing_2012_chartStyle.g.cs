﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle
{
    /// <summary>
    /// <para>Defines the ColorStyle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:colorStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation" /> <c>&lt;cs:variation></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:colorStyle")]
    public partial class ColorStyle : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorStyle class.
        /// </summary>
        public ColorStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>meth, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: meth</para>
        /// </summary>
        [SchemaAttr("meth")]
        public StringValue? Method
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:colorStyle");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>();
            builder.AddElement<ColorStyle>()
.AddAttribute("meth", a => a.Method, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleMethodEnum>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
})
.AddAttribute("id", a => a.Id);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation), 0, 0, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorStyle>(deep);

        internal ColorStyle(ChartColorStylePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ChartColorStylePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ChartColorStylePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ChartColorStylePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ChartColorStylePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ChartColorStylePart associated with this element.
        /// </summary>
        public ChartColorStylePart? ChartColorStylePart
        {
            get => OpenXmlPart as ChartColorStylePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ChartStyle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:chartStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties" /> <c>&lt;cs:dataPointMarkerLayout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle" /> <c>&lt;cs:axisTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis" /> <c>&lt;cs:categoryAxis></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea" /> <c>&lt;cs:chartArea></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel" /> <c>&lt;cs:dataLabel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout" /> <c>&lt;cs:dataLabelCallout></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint" /> <c>&lt;cs:dataPoint></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D" /> <c>&lt;cs:dataPoint3D></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine" /> <c>&lt;cs:dataPointLine></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker" /> <c>&lt;cs:dataPointMarker></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe" /> <c>&lt;cs:dataPointWireframe></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle" /> <c>&lt;cs:dataTable></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar" /> <c>&lt;cs:downBar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine" /> <c>&lt;cs:dropLine></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar" /> <c>&lt;cs:errorBar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor" /> <c>&lt;cs:floor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor" /> <c>&lt;cs:gridlineMajor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor" /> <c>&lt;cs:gridlineMinor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine" /> <c>&lt;cs:hiLoLine></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine" /> <c>&lt;cs:leaderLine></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle" /> <c>&lt;cs:legend></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea" /> <c>&lt;cs:plotArea></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D" /> <c>&lt;cs:plotArea3D></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis" /> <c>&lt;cs:seriesAxis></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine" /> <c>&lt;cs:seriesLine></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle" /> <c>&lt;cs:title></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle" /> <c>&lt;cs:trendline></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel" /> <c>&lt;cs:trendlineLabel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar" /> <c>&lt;cs:upBar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis" /> <c>&lt;cs:valueAxis></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall" /> <c>&lt;cs:wall></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:chartStyle")]
    public partial class ChartStyle : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ChartStyle class.
        /// </summary>
        public ChartStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:chartStyle");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall>();
            builder.AddElement<ChartStyle>()
.AddAttribute("id", a => a.Id);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>AxisTitle.</para>
        /// <para>Represents the following element tag in the schema: cs:axisTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle? AxisTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.AxisTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CategoryAxis.</para>
        /// <para>Represents the following element tag in the schema: cs:categoryAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis? CategoryAxis
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.CategoryAxis>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartArea.</para>
        /// <para>Represents the following element tag in the schema: cs:chartArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea? ChartArea
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabel.</para>
        /// <para>Represents the following element tag in the schema: cs:dataLabel.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel? DataLabel
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataLabelCallout.</para>
        /// <para>Represents the following element tag in the schema: cs:dataLabelCallout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout? DataLabelCallout
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelCallout>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPoint.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPoint.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint? DataPoint
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPoint3D.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPoint3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D? DataPoint3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPointLine.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPointLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine? DataPointLine
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPointMarker.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPointMarker.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker? DataPointMarker
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointMarker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MarkerLayoutProperties.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPointMarkerLayout.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties? MarkerLayoutProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataPointWireframe.</para>
        /// <para>Represents the following element tag in the schema: cs:dataPointWireframe.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe? DataPointWireframe
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataPointWireframe>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataTableStyle.</para>
        /// <para>Represents the following element tag in the schema: cs:dataTable.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle? DataTableStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataTableStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DownBar.</para>
        /// <para>Represents the following element tag in the schema: cs:downBar.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar? DownBar
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DownBar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DropLine.</para>
        /// <para>Represents the following element tag in the schema: cs:dropLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine? DropLine
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DropLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ErrorBar.</para>
        /// <para>Represents the following element tag in the schema: cs:errorBar.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar? ErrorBar
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ErrorBar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Floor.</para>
        /// <para>Represents the following element tag in the schema: cs:floor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor? Floor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Floor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GridlineMajor.</para>
        /// <para>Represents the following element tag in the schema: cs:gridlineMajor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor? GridlineMajor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMajor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GridlineMinor.</para>
        /// <para>Represents the following element tag in the schema: cs:gridlineMinor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor? GridlineMinor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.GridlineMinor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HiLoLine.</para>
        /// <para>Represents the following element tag in the schema: cs:hiLoLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine? HiLoLine
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.HiLoLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LeaderLine.</para>
        /// <para>Represents the following element tag in the schema: cs:leaderLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? LeaderLine
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LegendStyle.</para>
        /// <para>Represents the following element tag in the schema: cs:legend.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle? LegendStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PlotArea.</para>
        /// <para>Represents the following element tag in the schema: cs:plotArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea? PlotArea
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PlotArea3D.</para>
        /// <para>Represents the following element tag in the schema: cs:plotArea3D.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D? PlotArea3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.PlotArea3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeriesAxis.</para>
        /// <para>Represents the following element tag in the schema: cs:seriesAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis? SeriesAxis
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesAxis>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeriesLine.</para>
        /// <para>Represents the following element tag in the schema: cs:seriesLine.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine? SeriesLine
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.SeriesLine>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TitleStyle.</para>
        /// <para>Represents the following element tag in the schema: cs:title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle? TitleStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitleStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TrendlineStyle.</para>
        /// <para>Represents the following element tag in the schema: cs:trendline.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle? TrendlineStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TrendlineLabel.</para>
        /// <para>Represents the following element tag in the schema: cs:trendlineLabel.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel? TrendlineLabel
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TrendlineLabel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>UpBar.</para>
        /// <para>Represents the following element tag in the schema: cs:upBar.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar? UpBar
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.UpBar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ValueAxis.</para>
        /// <para>Represents the following element tag in the schema: cs:valueAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis? ValueAxis
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ValueAxis>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Wall.</para>
        /// <para>Represents the following element tag in the schema: cs:wall.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall? Wall
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Wall>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cs:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartStyle>(deep);

        internal ChartStyle(ChartStylePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ChartStylePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ChartStylePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ChartStylePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ChartStylePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ChartStylePart associated with this element.
        /// </summary>
        public ChartStylePart? ChartStylePart
        {
            get => OpenXmlPart as ChartStylePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ColorStyleVariation Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:variation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HueOffset" /> <c>&lt;a:hueOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Complement" /> <c>&lt;a:comp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaOffset" /> <c>&lt;a:alphaOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Gamma" /> <c>&lt;a:gamma></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Gray" /> <c>&lt;a:gray></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.InverseGamma" /> <c>&lt;a:invGamma></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Inverse" /> <c>&lt;a:inv></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Saturation" /> <c>&lt;a:sat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SaturationOffset" /> <c>&lt;a:satOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SaturationModulation" /> <c>&lt;a:satMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Luminance" /> <c>&lt;a:lum></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LuminanceOffset" /> <c>&lt;a:lumOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LuminanceModulation" /> <c>&lt;a:lumMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Red" /> <c>&lt;a:red></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RedOffset" /> <c>&lt;a:redOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RedModulation" /> <c>&lt;a:redMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Green" /> <c>&lt;a:green></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GreenOffset" /> <c>&lt;a:greenOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GreenModulation" /> <c>&lt;a:greenMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Blue" /> <c>&lt;a:blue></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlueOffset" /> <c>&lt;a:blueOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlueModulation" /> <c>&lt;a:blueMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Hue" /> <c>&lt;a:hue></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Tint" /> <c>&lt;a:tint></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shade" /> <c>&lt;a:shade></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Alpha" /> <c>&lt;a:alpha></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaModulation" /> <c>&lt;a:alphaMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HueModulation" /> <c>&lt;a:hueMod></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:variation")]
    public partial class ColorStyleVariation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorStyleVariation class.
        /// </summary>
        public ColorStyleVariation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorStyleVariation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorStyleVariation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorStyleVariation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorStyleVariation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorStyleVariation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorStyleVariation(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:variation");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HueOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Complement>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Gamma>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Gray>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.InverseGamma>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Inverse>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Saturation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SaturationOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SaturationModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Luminance>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LuminanceOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LuminanceModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Red>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RedOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RedModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Green>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GreenOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GreenModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blue>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlueOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlueModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Hue>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Tint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shade>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Alpha>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HueModulation>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tint), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shade), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Complement), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Inverse), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Gray), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Alpha), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Hue), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HueOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HueModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Saturation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SaturationOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SaturationModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Luminance), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Red), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RedOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RedModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Green), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GreenOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GreenModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blue), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlueOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlueModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Gamma), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.InverseGamma), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorStyleVariation>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:extLst")]
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:extLst");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleColor Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:styleClr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HueOffset" /> <c>&lt;a:hueOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Complement" /> <c>&lt;a:comp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaOffset" /> <c>&lt;a:alphaOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Gamma" /> <c>&lt;a:gamma></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Gray" /> <c>&lt;a:gray></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.InverseGamma" /> <c>&lt;a:invGamma></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Inverse" /> <c>&lt;a:inv></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Saturation" /> <c>&lt;a:sat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SaturationOffset" /> <c>&lt;a:satOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SaturationModulation" /> <c>&lt;a:satMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Luminance" /> <c>&lt;a:lum></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LuminanceOffset" /> <c>&lt;a:lumOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LuminanceModulation" /> <c>&lt;a:lumMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Red" /> <c>&lt;a:red></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RedOffset" /> <c>&lt;a:redOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RedModulation" /> <c>&lt;a:redMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Green" /> <c>&lt;a:green></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GreenOffset" /> <c>&lt;a:greenOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GreenModulation" /> <c>&lt;a:greenMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Blue" /> <c>&lt;a:blue></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlueOffset" /> <c>&lt;a:blueOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlueModulation" /> <c>&lt;a:blueMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Hue" /> <c>&lt;a:hue></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Tint" /> <c>&lt;a:tint></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shade" /> <c>&lt;a:shade></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Alpha" /> <c>&lt;a:alpha></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaModulation" /> <c>&lt;a:alphaMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HueModulation" /> <c>&lt;a:hueMod></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:styleClr")]
    public partial class StyleColor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleColor class.
        /// </summary>
        public StyleColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleColor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleColor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleColor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:styleClr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HueOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Complement>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Gamma>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Gray>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.InverseGamma>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Inverse>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Saturation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SaturationOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SaturationModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Luminance>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LuminanceOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LuminanceModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Red>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RedOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RedModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Green>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GreenOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GreenModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blue>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlueOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlueModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Hue>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Tint>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shade>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Alpha>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaModulation>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HueModulation>();
            builder.AddElement<StyleColor>()
.AddAttribute("val", a => a.Val, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<UInt32Value>(NumberValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColorEnum>>(EnumValidator.Instance);
union.AddValidator(StringValidator.Instance);
});
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tint), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shade), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Complement), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Inverse), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Gray), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Alpha), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Hue), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HueOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HueModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Saturation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SaturationOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SaturationModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Luminance), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Red), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RedOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RedModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Green), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GreenOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GreenModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blue), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlueOffset), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlueModulation), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Gamma), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.InverseGamma), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleColor>(deep);
    }

    /// <summary>
    /// <para>Defines the LineReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:lnRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor" /> <c>&lt;cs:styleClr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:lnRef")]
    public partial class LineReference : StyleReference
    {
        /// <summary>
        /// Initializes a new instance of the LineReference class.
        /// </summary>
        public LineReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:lnRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineReference>(deep);
    }

    /// <summary>
    /// <para>Defines the FillReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:fillRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor" /> <c>&lt;cs:styleClr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:fillRef")]
    public partial class FillReference : StyleReference
    {
        /// <summary>
        /// Initializes a new instance of the FillReference class.
        /// </summary>
        public FillReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FillReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:fillRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillReference>(deep);
    }

    /// <summary>
    /// <para>Defines the EffectReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:effectRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor" /> <c>&lt;cs:styleClr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:effectRef")]
    public partial class EffectReference : StyleReference
    {
        /// <summary>
        /// Initializes a new instance of the EffectReference class.
        /// </summary>
        public EffectReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EffectReference(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:effectRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectReference>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor" /> <c>&lt;cs:styleClr></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class StyleReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleReference class.
        /// </summary>
        protected StyleReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected StyleReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idx, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr("idx")]
        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mods, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: mods</para>
        /// </summary>
        [SchemaAttr("mods")]
        public ListValue<StringValue>? Modifiers
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor>();
            builder.AddElement<StyleReference>()
.AddAttribute("idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("mods", a => a.Modifiers);
        }
    }

    /// <summary>
    /// <para>Defines the LineWidthScale Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:lineWidthScale.</para>
    /// </summary>
    [SchemaAttr("cs:lineWidthScale")]
    public partial class LineWidthScale : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LineWidthScale class.
        /// </summary>
        public LineWidthScale() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineWidthScale class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LineWidthScale(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DoubleValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<DoubleValue>(NumberValidator.Instance);
            builder.SetSchema("cs:lineWidthScale");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineWidthScale>(deep);
    }

    /// <summary>
    /// <para>Defines the FontReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:fontRef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor" /> <c>&lt;cs:styleClr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:fontRef")]
    public partial class FontReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the FontReference class.
        /// </summary>
        public FontReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FontReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FontReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FontReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FontReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idx, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        [SchemaAttr("idx")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues>? Index
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mods, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: mods</para>
        /// </summary>
        [SchemaAttr("mods")]
        public ListValue<StringValue>? Modifiers
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:fontRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor>();
            builder.AddElement<FontReference>()
.AddAttribute("idx", a => a.Index, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("mods", a => a.Modifiers);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FontReference>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomGeometry" /> <c>&lt;a:custGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetGeometry" /> <c>&lt;a:prstGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Transform2D" /> <c>&lt;a:xfrm></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:spPr")]
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [SchemaAttr("bwMode")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:spPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddElement<ShapeProperties>()
.AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the TextCharacterPropertiesType Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:defRPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RightToLeft" /> <c>&lt;a:rtl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Highlight" /> <c>&lt;a:highlight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnClick" /> <c>&lt;a:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver" /> <c>&lt;a:hlinkMouseOver></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Underline" /> <c>&lt;a:uLn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LatinFont" /> <c>&lt;a:latin></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EastAsianFont" /> <c>&lt;a:ea></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ComplexScriptFont" /> <c>&lt;a:cs></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SymbolFont" /> <c>&lt;a:sym></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.UnderlineFillText" /> <c>&lt;a:uFillTx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.UnderlineFill" /> <c>&lt;a:uFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.UnderlineFollowsText" /> <c>&lt;a:uLnTx></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:defRPr")]
    public partial class TextCharacterPropertiesType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextCharacterPropertiesType class.
        /// </summary>
        public TextCharacterPropertiesType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharacterPropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextCharacterPropertiesType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharacterPropertiesType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextCharacterPropertiesType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextCharacterPropertiesType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextCharacterPropertiesType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>kumimoji</para>
        /// <para>Represents the following attribute in the schema: kumimoji</para>
        /// </summary>
        [SchemaAttr("kumimoji")]
        public BooleanValue? Kumimoji
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        [SchemaAttr("lang")]
        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>altLang</para>
        /// <para>Represents the following attribute in the schema: altLang</para>
        /// </summary>
        [SchemaAttr("altLang")]
        public StringValue? AlternativeLanguage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sz</para>
        /// <para>Represents the following attribute in the schema: sz</para>
        /// </summary>
        [SchemaAttr("sz")]
        public Int32Value? FontSize
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        [SchemaAttr("b")]
        public BooleanValue? Bold
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>i</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>
        [SchemaAttr("i")]
        public BooleanValue? Italic
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>u</para>
        /// <para>Represents the following attribute in the schema: u</para>
        /// </summary>
        [SchemaAttr("u")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues>? Underline
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextUnderlineValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>strike</para>
        /// <para>Represents the following attribute in the schema: strike</para>
        /// </summary>
        [SchemaAttr("strike")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues>? Strike
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextStrikeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>kern</para>
        /// <para>Represents the following attribute in the schema: kern</para>
        /// </summary>
        [SchemaAttr("kern")]
        public Int32Value? Kerning
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cap</para>
        /// <para>Represents the following attribute in the schema: cap</para>
        /// </summary>
        [SchemaAttr("cap")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues>? Capital
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextCapsValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>spc</para>
        /// <para>Represents the following attribute in the schema: spc</para>
        /// </summary>
        [SchemaAttr("spc")]
        public Int32Value? Spacing
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>normalizeH</para>
        /// <para>Represents the following attribute in the schema: normalizeH</para>
        /// </summary>
        [SchemaAttr("normalizeH")]
        public BooleanValue? NormalizeHeight
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>baseline</para>
        /// <para>Represents the following attribute in the schema: baseline</para>
        /// </summary>
        [SchemaAttr("baseline")]
        public Int32Value? Baseline
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noProof</para>
        /// <para>Represents the following attribute in the schema: noProof</para>
        /// </summary>
        [SchemaAttr("noProof")]
        public BooleanValue? NoProof
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dirty</para>
        /// <para>Represents the following attribute in the schema: dirty</para>
        /// </summary>
        [SchemaAttr("dirty")]
        public BooleanValue? Dirty
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>err</para>
        /// <para>Represents the following attribute in the schema: err</para>
        /// </summary>
        [SchemaAttr("err")]
        public BooleanValue? SpellingError
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>smtClean</para>
        /// <para>Represents the following attribute in the schema: smtClean</para>
        /// </summary>
        [SchemaAttr("smtClean")]
        public BooleanValue? SmartTagClean
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>smtId</para>
        /// <para>Represents the following attribute in the schema: smtId</para>
        /// </summary>
        [SchemaAttr("smtId")]
        public UInt32Value? SmartTagId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bmk</para>
        /// <para>Represents the following attribute in the schema: bmk</para>
        /// </summary>
        [SchemaAttr("bmk")]
        public StringValue? Bookmark
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:defRPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RightToLeft>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Highlight>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Underline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LatinFont>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EastAsianFont>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SymbolFont>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.UnderlineFillText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.UnderlineFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.UnderlineFollowsText>();
            builder.AddElement<TextCharacterPropertiesType>()
.AddAttribute("kumimoji", a => a.Kumimoji)
.AddAttribute("lang", a => a.Language)
.AddAttribute("altLang", a => a.AlternativeLanguage)
.AddAttribute("sz", a => a.FontSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (100L), MaxInclusive = (400000L) });
})
.AddAttribute("b", a => a.Bold)
.AddAttribute("i", a => a.Italic)
.AddAttribute("u", a => a.Underline, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("strike", a => a.Strike, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("kern", a => a.Kerning, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (400000L) });
})
.AddAttribute("cap", a => a.Capital, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("spc", a => a.Spacing, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-400000L), MaxInclusive = (400000L) });
})
.AddAttribute("normalizeH", a => a.NormalizeHeight)
.AddAttribute("baseline", a => a.Baseline)
.AddAttribute("noProof", a => a.NoProof)
.AddAttribute("dirty", a => a.Dirty)
.AddAttribute("err", a => a.SpellingError)
.AddAttribute("smtClean", a => a.SmartTagClean)
.AddAttribute("smtId", a => a.SmartTagId)
.AddAttribute("bmk", a => a.Bookmark);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Highlight), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFollowsText), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Underline), 0, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFillText), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.UnderlineFill), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LatinFont), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EastAsianFont), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ComplexScriptFont), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SymbolFont), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RightToLeft), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Outline.</para>
        /// <para>Represents the following element tag in the schema: a:ln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Outline? Outline
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Outline>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextCharacterPropertiesType>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:bodyPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FlatText" /> <c>&lt;a:flatTx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetTextWrap" /> <c>&lt;a:prstTxWarp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoAutoFit" /> <c>&lt;a:noAutofit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NormalAutoFit" /> <c>&lt;a:normAutofit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapeAutoFit" /> <c>&lt;a:spAutoFit></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:bodyPr")]
    public partial class TextBodyProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class.
        /// </summary>
        public TextBodyProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBodyProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        [SchemaAttr("rot")]
        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Paragraph Spacing</para>
        /// <para>Represents the following attribute in the schema: spcFirstLastPara</para>
        /// </summary>
        [SchemaAttr("spcFirstLastPara")]
        public BooleanValue? UseParagraphSpacing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Vertical Overflow</para>
        /// <para>Represents the following attribute in the schema: vertOverflow</para>
        /// </summary>
        [SchemaAttr("vertOverflow")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>? VerticalOverflow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Horizontal Overflow</para>
        /// <para>Represents the following attribute in the schema: horzOverflow</para>
        /// </summary>
        [SchemaAttr("horzOverflow")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>? HorizontalOverflow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Text</para>
        /// <para>Represents the following attribute in the schema: vert</para>
        /// </summary>
        [SchemaAttr("vert")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>? Vertical
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Wrapping Type</para>
        /// <para>Represents the following attribute in the schema: wrap</para>
        /// </summary>
        [SchemaAttr("wrap")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>? Wrap
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Left Inset</para>
        /// <para>Represents the following attribute in the schema: lIns</para>
        /// </summary>
        [SchemaAttr("lIns")]
        public Int32Value? LeftInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top Inset</para>
        /// <para>Represents the following attribute in the schema: tIns</para>
        /// </summary>
        [SchemaAttr("tIns")]
        public Int32Value? TopInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right Inset</para>
        /// <para>Represents the following attribute in the schema: rIns</para>
        /// </summary>
        [SchemaAttr("rIns")]
        public Int32Value? RightInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Inset</para>
        /// <para>Represents the following attribute in the schema: bIns</para>
        /// </summary>
        [SchemaAttr("bIns")]
        public Int32Value? BottomInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Number of Columns</para>
        /// <para>Represents the following attribute in the schema: numCol</para>
        /// </summary>
        [SchemaAttr("numCol")]
        public Int32Value? ColumnCount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Space Between Columns</para>
        /// <para>Represents the following attribute in the schema: spcCol</para>
        /// </summary>
        [SchemaAttr("spcCol")]
        public Int32Value? ColumnSpacing
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Columns Right-To-Left</para>
        /// <para>Represents the following attribute in the schema: rtlCol</para>
        /// </summary>
        [SchemaAttr("rtlCol")]
        public BooleanValue? RightToLeftColumns
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>From WordArt</para>
        /// <para>Represents the following attribute in the schema: fromWordArt</para>
        /// </summary>
        [SchemaAttr("fromWordArt")]
        public BooleanValue? FromWordArt
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Anchor</para>
        /// <para>Represents the following attribute in the schema: anchor</para>
        /// </summary>
        [SchemaAttr("anchor")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>? Anchor
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Anchor Center</para>
        /// <para>Represents the following attribute in the schema: anchorCtr</para>
        /// </summary>
        [SchemaAttr("anchorCtr")]
        public BooleanValue? AnchorCenter
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Anti-Alias</para>
        /// <para>Represents the following attribute in the schema: forceAA</para>
        /// </summary>
        [SchemaAttr("forceAA")]
        public BooleanValue? ForceAntiAlias
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Upright</para>
        /// <para>Represents the following attribute in the schema: upright</para>
        /// </summary>
        [SchemaAttr("upright")]
        public BooleanValue? UpRight
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Compatible Line Spacing</para>
        /// <para>Represents the following attribute in the schema: compatLnSpc</para>
        /// </summary>
        [SchemaAttr("compatLnSpc")]
        public BooleanValue? CompatibleLineSpacing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:bodyPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FlatText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
            builder.AddElement<TextBodyProperties>()
.AddAttribute("rot", a => a.Rotation)
.AddAttribute("spcFirstLastPara", a => a.UseParagraphSpacing)
.AddAttribute("vertOverflow", a => a.VerticalOverflow, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("horzOverflow", a => a.HorizontalOverflow, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("vert", a => a.Vertical, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("wrap", a => a.Wrap, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("lIns", a => a.LeftInset)
.AddAttribute("tIns", a => a.TopInset)
.AddAttribute("rIns", a => a.RightInset)
.AddAttribute("bIns", a => a.BottomInset)
.AddAttribute("numCol", a => a.ColumnCount, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (16L) });
})
.AddAttribute("spcCol", a => a.ColumnSpacing, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
})
.AddAttribute("rtlCol", a => a.RightToLeftColumns)
.AddAttribute("fromWordArt", a => a.FromWordArt)
.AddAttribute("anchor", a => a.Anchor, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("anchorCtr", a => a.AnchorCenter)
.AddAttribute("forceAA", a => a.ForceAntiAlias)
.AddAttribute("upright", a => a.UpRight)
.AddAttribute("compatLnSpc", a => a.CompatibleLineSpacing);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetTextWrap), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoAutoFit), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NormalAutoFit), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeAutoFit), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FlatText), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Preset Text Shape.</para>
        /// <para>Represents the following element tag in the schema: a:prstTxWarp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetTextWrap? PresetTextWrap
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryAxisProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:categoryAxis.</para>
    /// </summary>
    [SchemaAttr("cs:categoryAxis")]
    public partial class CategoryAxisProperties : AxisProperties
    {
        /// <summary>
        /// Initializes a new instance of the CategoryAxisProperties class.
        /// </summary>
        public CategoryAxisProperties() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:categoryAxis");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxisProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesAxisProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:seriesAxis.</para>
    /// </summary>
    [SchemaAttr("cs:seriesAxis")]
    public partial class SeriesAxisProperties : AxisProperties
    {
        /// <summary>
        /// Initializes a new instance of the SeriesAxisProperties class.
        /// </summary>
        public SeriesAxisProperties() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:seriesAxis");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesAxisProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ValueAxisProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:valueAxis.</para>
    /// </summary>
    [SchemaAttr("cs:valueAxis")]
    public partial class ValueAxisProperties : AxisProperties
    {
        /// <summary>
        /// Initializes a new instance of the ValueAxisProperties class.
        /// </summary>
        public ValueAxisProperties() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:valueAxis");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxisProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class AxisProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AxisProperties class.
        /// </summary>
        protected AxisProperties() : base()
        {
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? Visible
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>majorTick, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: majorTick</para>
        /// </summary>
        [SchemaAttr("majorTick")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch>? MajorTick
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minorTick, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: minorTick</para>
        /// </summary>
        [SchemaAttr("minorTick")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch>? MinorTickProp
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickMarkNinch>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>labelPosition, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: labelPosition</para>
        /// </summary>
        [SchemaAttr("labelPosition")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickLabelPositionNinch>? LabelPosition
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TickLabelPositionNinch>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>majorGridlines, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: majorGridlines</para>
        /// </summary>
        [SchemaAttr("majorGridlines")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? MajorGridlines
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minorGridlines, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: minorGridlines</para>
        /// </summary>
        [SchemaAttr("minorGridlines")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? MinorGridlinesProp
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? TitleProp
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<AxisProperties>()
                           .AddAttribute("visible", a => a.Visible, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           })
                           .AddAttribute("majorTick", a => a.MajorTick, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           })
                           .AddAttribute("minorTick", a => a.MinorTickProp, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           })
                           .AddAttribute("labelPosition", a => a.LabelPosition, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           })
                           .AddAttribute("majorGridlines", a => a.MajorGridlines, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           })
                           .AddAttribute("minorGridlines", a => a.MinorGridlinesProp, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           })
                           .AddAttribute("title", a => a.TitleProp, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the DataSeries Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataSeries.</para>
    /// </summary>
    [SchemaAttr("cs:dataSeries")]
    public partial class DataSeries : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataSeries class.
        /// </summary>
        public DataSeries() : base()
        {
        }

        /// <summary>
        /// <para>overlap, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: overlap</para>
        /// </summary>
        [SchemaAttr("overlap")]
        public SByteValue? Overlap
        {
            get => GetAttribute<SByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>gapWidth, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: gapWidth</para>
        /// </summary>
        [SchemaAttr("gapWidth")]
        public UInt16Value? GapWidth
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>gapDepth, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: gapDepth</para>
        /// </summary>
        [SchemaAttr("gapDepth")]
        public UInt16Value? GapDepth
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>doughnutHoleSize, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: doughnutHoleSize</para>
        /// </summary>
        [SchemaAttr("doughnutHoleSize")]
        public ByteValue? DoughnutHoleSize
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>markerVisible, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: markerVisible</para>
        /// </summary>
        [SchemaAttr("markerVisible")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? MarkerVisible
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hiloLines, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: hiloLines</para>
        /// </summary>
        [SchemaAttr("hiloLines")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? HiloLines
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dropLines, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: dropLines</para>
        /// </summary>
        [SchemaAttr("dropLines")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? DropLines
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seriesLines, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: seriesLines</para>
        /// </summary>
        [SchemaAttr("seriesLines")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? SeriesLines
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataSeries");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DataSeries>()
.AddAttribute("overlap", a => a.Overlap, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-100L), MaxInclusive = (100L) });
})
.AddAttribute("gapWidth", a => a.GapWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (500L) });
})
.AddAttribute("gapDepth", a => a.GapDepth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (500L) });
})
.AddAttribute("doughnutHoleSize", a => a.DoughnutHoleSize, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (10L), MaxInclusive = (90L) });
})
.AddAttribute("markerVisible", a => a.MarkerVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("hiloLines", a => a.HiloLines, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("dropLines", a => a.DropLines, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("seriesLines", a => a.SeriesLines, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataSeries>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabels Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataLabels.</para>
    /// </summary>
    [SchemaAttr("cs:dataLabels")]
    public partial class DataLabels : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataLabels class.
        /// </summary>
        public DataLabels() : base()
        {
        }

        /// <summary>
        /// <para>position, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        [SchemaAttr("position")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelsPosition>? Position
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.DataLabelsPosition>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? Value
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seriesName, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: seriesName</para>
        /// </summary>
        [SchemaAttr("seriesName")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? SeriesName
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>categoryName, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: categoryName</para>
        /// </summary>
        [SchemaAttr("categoryName")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? CategoryName
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>legendKey, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: legendKey</para>
        /// </summary>
        [SchemaAttr("legendKey")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? LegendKey
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>percentage, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: percentage</para>
        /// </summary>
        [SchemaAttr("percentage")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? Percentage
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataLabels");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DataLabels>()
.AddAttribute("position", a => a.Position, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("value", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("seriesName", a => a.SeriesName, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("categoryName", a => a.CategoryName, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("legendKey", a => a.LegendKey, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("percentage", a => a.Percentage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabels>(deep);
    }

    /// <summary>
    /// <para>Defines the DataTable Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataTable.</para>
    /// </summary>
    [SchemaAttr("cs:dataTable")]
    public partial class DataTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataTable class.
        /// </summary>
        public DataTable() : base()
        {
        }

        /// <summary>
        /// <para>legendKeys, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: legendKeys</para>
        /// </summary>
        [SchemaAttr("legendKeys")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? LegendKeys
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>horizontalBorder, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: horizontalBorder</para>
        /// </summary>
        [SchemaAttr("horizontalBorder")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? HorizontalBorder
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verticalBorder, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: verticalBorder</para>
        /// </summary>
        [SchemaAttr("verticalBorder")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? VerticalBorder
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>outlineBorder, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: outlineBorder</para>
        /// </summary>
        [SchemaAttr("outlineBorder")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? OutlineBorder
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DataTable>()
.AddAttribute("legendKeys", a => a.LegendKeys, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("horizontalBorder", a => a.HorizontalBorder, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("verticalBorder", a => a.VerticalBorder, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("outlineBorder", a => a.OutlineBorder, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataTable>(deep);
    }

    /// <summary>
    /// <para>Defines the Legend Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:legend.</para>
    /// </summary>
    [SchemaAttr("cs:legend")]
    public partial class Legend : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Legend class.
        /// </summary>
        public Legend() : base()
        {
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? Visible
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>includeInLayout, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: includeInLayout</para>
        /// </summary>
        [SchemaAttr("includeInLayout")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? IncludeInLayout
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>position, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        [SchemaAttr("position")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendPosition>? Position
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LegendPosition>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:legend");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<Legend>()
.AddAttribute("visible", a => a.Visible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("includeInLayout", a => a.IncludeInLayout, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("position", a => a.Position, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Legend>(deep);
    }

    /// <summary>
    /// <para>Defines the Title Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:title.</para>
    /// </summary>
    [SchemaAttr("cs:title")]
    public partial class Title : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Title class.
        /// </summary>
        public Title() : base()
        {
        }

        /// <summary>
        /// <para>position, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        [SchemaAttr("position")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitlePosition>? Position
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TitlePosition>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:title");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<Title>()
.AddAttribute("position", a => a.Position, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Title>(deep);
    }

    /// <summary>
    /// <para>Defines the Trendline Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:trendline.</para>
    /// </summary>
    [SchemaAttr("cs:trendline")]
    public partial class Trendline : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Trendline class.
        /// </summary>
        public Trendline() : base()
        {
        }

        /// <summary>
        /// <para>add, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: add</para>
        /// </summary>
        [SchemaAttr("add")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? Add
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>equation, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: equation</para>
        /// </summary>
        [SchemaAttr("equation")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? Equation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rsquared, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: rsquared</para>
        /// </summary>
        [SchemaAttr("rsquared")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? RSquared
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:trendline");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<Trendline>()
.AddAttribute("add", a => a.Add, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("equation", a => a.Equation, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("rsquared", a => a.RSquared, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Trendline>(deep);
    }

    /// <summary>
    /// <para>Defines the View3DProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:view3D.</para>
    /// </summary>
    [SchemaAttr("cs:view3D")]
    public partial class View3DProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the View3DProperties class.
        /// </summary>
        public View3DProperties() : base()
        {
        }

        /// <summary>
        /// <para>rotX, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: rotX</para>
        /// </summary>
        [SchemaAttr("rotX")]
        public SByteValue? RotX
        {
            get => GetAttribute<SByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rotY, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: rotY</para>
        /// </summary>
        [SchemaAttr("rotY")]
        public UInt16Value? RotY
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rAngAx, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: rAngAx</para>
        /// </summary>
        [SchemaAttr("rAngAx")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>? RightAngleAxes
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.Boolean>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>perspective, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: perspective</para>
        /// </summary>
        [SchemaAttr("perspective")]
        public ByteValue? Perspective
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>heightPercent, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: heightPercent</para>
        /// </summary>
        [SchemaAttr("heightPercent")]
        public UInt16Value? HeightPercent
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>depthPercent, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: depthPercent</para>
        /// </summary>
        [SchemaAttr("depthPercent")]
        public UInt16Value? DepthPercent
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:view3D");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<View3DProperties>()
.AddAttribute("rotX", a => a.RotX, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-90L), MaxInclusive = (90L) });
})
.AddAttribute("rotY", a => a.RotY, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (360L) });
})
.AddAttribute("rAngAx", a => a.RightAngleAxes, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("perspective", a => a.Perspective, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (240L) });
})
.AddAttribute("heightPercent", a => a.HeightPercent, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (5L), MaxInclusive = (500L) });
})
.AddAttribute("depthPercent", a => a.DepthPercent, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (20L), MaxInclusive = (2000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<View3DProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the AxisTitle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:axisTitle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:axisTitle")]
    public partial class AxisTitle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the AxisTitle class.
        /// </summary>
        public AxisTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AxisTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AxisTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AxisTitle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:axisTitle");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the CategoryAxis Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:categoryAxis.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:categoryAxis")]
    public partial class CategoryAxis : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the CategoryAxis class.
        /// </summary>
        public CategoryAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryAxis(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryAxis class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryAxis(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:categoryAxis");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryAxis>(deep);
    }

    /// <summary>
    /// <para>Defines the ChartArea Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:chartArea.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:chartArea")]
    public partial class ChartArea : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the ChartArea class.
        /// </summary>
        public ChartArea() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartArea(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChartArea(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChartArea class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChartArea(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:chartArea");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartArea>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabel Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataLabel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dataLabel")]
    public partial class DataLabel : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataLabel class.
        /// </summary>
        public DataLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataLabel");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the DataLabelCallout Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataLabelCallout.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dataLabelCallout")]
    public partial class DataLabelCallout : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataLabelCallout class.
        /// </summary>
        public DataLabelCallout() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelCallout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelCallout(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelCallout class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataLabelCallout(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataLabelCallout class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataLabelCallout(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataLabelCallout");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataLabelCallout>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPoint Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPoint.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dataPoint")]
    public partial class DataPoint : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPoint class.
        /// </summary>
        public DataPoint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataPoint(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataPoint");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPoint3D Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPoint3D.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dataPoint3D")]
    public partial class DataPoint3D : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPoint3D class.
        /// </summary>
        public DataPoint3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPoint3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPoint3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataPoint3D(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataPoint3D");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPoint3D>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPointLine Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPointLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dataPointLine")]
    public partial class DataPointLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPointLine class.
        /// </summary>
        public DataPointLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointLine(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointLine class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataPointLine(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataPointLine");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointLine>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPointMarker Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPointMarker.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dataPointMarker")]
    public partial class DataPointMarker : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPointMarker class.
        /// </summary>
        public DataPointMarker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointMarker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointMarker(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointMarker class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataPointMarker(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataPointMarker");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointMarker>(deep);
    }

    /// <summary>
    /// <para>Defines the DataPointWireframe Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPointWireframe.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dataPointWireframe")]
    public partial class DataPointWireframe : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataPointWireframe class.
        /// </summary>
        public DataPointWireframe() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointWireframe class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointWireframe(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointWireframe class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataPointWireframe(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataPointWireframe class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataPointWireframe(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataPointWireframe");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataPointWireframe>(deep);
    }

    /// <summary>
    /// <para>Defines the DataTableStyle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataTable.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dataTable")]
    public partial class DataTableStyle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DataTableStyle class.
        /// </summary>
        public DataTableStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataTableStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataTableStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataTableStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataTableStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataTableStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataTableStyle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataTableStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the DownBar Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:downBar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:downBar")]
    public partial class DownBar : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DownBar class.
        /// </summary>
        public DownBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DownBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DownBar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DownBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DownBar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DownBar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DownBar(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:downBar");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DownBar>(deep);
    }

    /// <summary>
    /// <para>Defines the DropLine Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dropLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:dropLine")]
    public partial class DropLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the DropLine class.
        /// </summary>
        public DropLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropLine(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropLine class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DropLine(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dropLine");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropLine>(deep);
    }

    /// <summary>
    /// <para>Defines the ErrorBar Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:errorBar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:errorBar")]
    public partial class ErrorBar : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the ErrorBar class.
        /// </summary>
        public ErrorBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ErrorBar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ErrorBar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorBar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ErrorBar(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:errorBar");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ErrorBar>(deep);
    }

    /// <summary>
    /// <para>Defines the Floor Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:floor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:floor")]
    public partial class Floor : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the Floor class.
        /// </summary>
        public Floor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Floor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Floor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Floor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Floor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Floor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Floor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:floor");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Floor>(deep);
    }

    /// <summary>
    /// <para>Defines the GridlineMajor Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:gridlineMajor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:gridlineMajor")]
    public partial class GridlineMajor : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the GridlineMajor class.
        /// </summary>
        public GridlineMajor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GridlineMajor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GridlineMajor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GridlineMajor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GridlineMajor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GridlineMajor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GridlineMajor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:gridlineMajor");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GridlineMajor>(deep);
    }

    /// <summary>
    /// <para>Defines the GridlineMinor Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:gridlineMinor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:gridlineMinor")]
    public partial class GridlineMinor : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the GridlineMinor class.
        /// </summary>
        public GridlineMinor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GridlineMinor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GridlineMinor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GridlineMinor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GridlineMinor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GridlineMinor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GridlineMinor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:gridlineMinor");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GridlineMinor>(deep);
    }

    /// <summary>
    /// <para>Defines the HiLoLine Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:hiLoLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:hiLoLine")]
    public partial class HiLoLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the HiLoLine class.
        /// </summary>
        public HiLoLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiLoLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HiLoLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiLoLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HiLoLine(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiLoLine class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HiLoLine(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:hiLoLine");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiLoLine>(deep);
    }

    /// <summary>
    /// <para>Defines the LeaderLine Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:leaderLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:leaderLine")]
    public partial class LeaderLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the LeaderLine class.
        /// </summary>
        public LeaderLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LeaderLine(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LeaderLine class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LeaderLine(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:leaderLine");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeaderLine>(deep);
    }

    /// <summary>
    /// <para>Defines the LegendStyle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:legend.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:legend")]
    public partial class LegendStyle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the LegendStyle class.
        /// </summary>
        public LegendStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LegendStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LegendStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LegendStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LegendStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LegendStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LegendStyle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:legend");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegendStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotArea Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:plotArea.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:plotArea")]
    public partial class PlotArea : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the PlotArea class.
        /// </summary>
        public PlotArea() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PlotArea(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:plotArea");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea>(deep);
    }

    /// <summary>
    /// <para>Defines the PlotArea3D Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:plotArea3D.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:plotArea3D")]
    public partial class PlotArea3D : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the PlotArea3D class.
        /// </summary>
        public PlotArea3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PlotArea3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PlotArea3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PlotArea3D(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:plotArea3D");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlotArea3D>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesAxis Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:seriesAxis.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:seriesAxis")]
    public partial class SeriesAxis : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the SeriesAxis class.
        /// </summary>
        public SeriesAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesAxis(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesAxis class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SeriesAxis(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:seriesAxis");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesAxis>(deep);
    }

    /// <summary>
    /// <para>Defines the SeriesLine Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:seriesLine.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:seriesLine")]
    public partial class SeriesLine : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the SeriesLine class.
        /// </summary>
        public SeriesLine() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesLine(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLine class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SeriesLine(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SeriesLine class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SeriesLine(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:seriesLine");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesLine>(deep);
    }

    /// <summary>
    /// <para>Defines the TitleStyle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:title.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:title")]
    public partial class TitleStyle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the TitleStyle class.
        /// </summary>
        public TitleStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitleStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitleStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitleStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitleStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitleStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TitleStyle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:title");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitleStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TrendlineStyle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:trendline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:trendline")]
    public partial class TrendlineStyle : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the TrendlineStyle class.
        /// </summary>
        public TrendlineStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrendlineStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrendlineStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TrendlineStyle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:trendline");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TrendlineLabel Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:trendlineLabel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:trendlineLabel")]
    public partial class TrendlineLabel : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class.
        /// </summary>
        public TrendlineLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrendlineLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TrendlineLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrendlineLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TrendlineLabel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:trendlineLabel");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TrendlineLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the UpBar Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:upBar.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:upBar")]
    public partial class UpBar : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the UpBar class.
        /// </summary>
        public UpBar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UpBar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpBar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UpBar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UpBar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UpBar(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:upBar");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpBar>(deep);
    }

    /// <summary>
    /// <para>Defines the ValueAxis Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:valueAxis.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:valueAxis")]
    public partial class ValueAxis : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the ValueAxis class.
        /// </summary>
        public ValueAxis() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValueAxis(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueAxis class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ValueAxis(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueAxis class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ValueAxis(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:valueAxis");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ValueAxis>(deep);
    }

    /// <summary>
    /// <para>Defines the Wall Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:wall.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cs:wall")]
    public partial class Wall : StyleEntry
    {
        /// <summary>
        /// Initializes a new instance of the Wall class.
        /// </summary>
        public Wall() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Wall class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Wall(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Wall class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Wall(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Wall class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Wall(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:wall");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Wall>(deep);
    }

    /// <summary>
    /// <para>Defines the StyleEntry Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList" /> <c>&lt;cs:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties" /> <c>&lt;cs:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties" /> <c>&lt;cs:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType" /> <c>&lt;cs:defRPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference" /> <c>&lt;cs:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference" /> <c>&lt;cs:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference" /> <c>&lt;cs:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference" /> <c>&lt;cs:effectRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale" /> <c>&lt;cs:lineWidthScale></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class StyleEntry : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleEntry class.
        /// </summary>
        protected StyleEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleEntry(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected StyleEntry(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleEntry class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected StyleEntry(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>mods, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: mods</para>
        /// </summary>
        [SchemaAttr("mods")]
        public ListValue<StringValue>? Modifiers
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale>();
            builder.AddElement<StyleEntry>()
.AddAttribute("mods", a => a.Modifiers);
        }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: cs:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference? LineReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LineWidthScale.</para>
        /// <para>Represents the following element tag in the schema: cs:lineWidthScale.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale? LineWidthScale
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: cs:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference? FillReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: cs:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference? EffectReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FontReference.</para>
        /// <para>Represents the following element tag in the schema: cs:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cs:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextCharacterPropertiesType.</para>
        /// <para>Represents the following element tag in the schema: cs:defRPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? TextCharacterPropertiesType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TextBodyProperties.</para>
        /// <para>Represents the following element tag in the schema: cs:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties? TextBodyProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: cs:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cs = http://schemas.microsoft.com/office/drawing/2012/chartStyle
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the MarkerLayoutProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cs:dataPointMarkerLayout.</para>
    /// </summary>
    [SchemaAttr("cs:dataPointMarkerLayout")]
    public partial class MarkerLayoutProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MarkerLayoutProperties class.
        /// </summary>
        public MarkerLayoutProperties() : base()
        {
        }

        /// <summary>
        /// <para>symbol, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: symbol</para>
        /// </summary>
        [SchemaAttr("symbol")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle>? Symbol
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>size, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public ByteValue? Size
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cs:dataPointMarkerLayout");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<MarkerLayoutProperties>()
.AddAttribute("symbol", a => a.Symbol, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute("size", a => a.Size, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (2L), MaxInclusive = (72L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MarkerLayoutProperties>(deep);
    }

    /// <summary>
    /// Defines the ColorStyleMethodEnum enumeration.
    /// </summary>
    public enum ColorStyleMethodEnum
    {
        /// <summary>
        /// cycle.
        /// <para>When the item is serialized out as xml, its value is "cycle".</para>
        /// </summary>
        [EnumString("cycle")]
        Cycle,
        /// <summary>
        /// withinLinear.
        /// <para>When the item is serialized out as xml, its value is "withinLinear".</para>
        /// </summary>
        [EnumString("withinLinear")]
        WithinLinear,
        /// <summary>
        /// acrossLinear.
        /// <para>When the item is serialized out as xml, its value is "acrossLinear".</para>
        /// </summary>
        [EnumString("acrossLinear")]
        AcrossLinear,
        /// <summary>
        /// withinLinearReversed.
        /// <para>When the item is serialized out as xml, its value is "withinLinearReversed".</para>
        /// </summary>
        [EnumString("withinLinearReversed")]
        WithinLinearReversed,
        /// <summary>
        /// acrossLinearReversed.
        /// <para>When the item is serialized out as xml, its value is "acrossLinearReversed".</para>
        /// </summary>
        [EnumString("acrossLinearReversed")]
        AcrossLinearReversed
    }

    /// <summary>
    /// Defines the StyleReferenceModifierEnum enumeration.
    /// </summary>
    public enum StyleReferenceModifierEnum
    {
        /// <summary>
        /// ignoreCSTransforms.
        /// <para>When the item is serialized out as xml, its value is "ignoreCSTransforms".</para>
        /// </summary>
        [EnumString("ignoreCSTransforms")]
        IgnoreCSTransforms
    }

    /// <summary>
    /// Defines the StyleColorEnum enumeration.
    /// </summary>
    public enum StyleColorEnum
    {
        /// <summary>
        /// auto.
        /// <para>When the item is serialized out as xml, its value is "auto".</para>
        /// </summary>
        [EnumString("auto")]
        Automatic
    }

    /// <summary>
    /// Defines the StyleEntryModifierEnum enumeration.
    /// </summary>
    public enum StyleEntryModifierEnum
    {
        /// <summary>
        /// allowNoFillOverride.
        /// <para>When the item is serialized out as xml, its value is "allowNoFillOverride".</para>
        /// </summary>
        [EnumString("allowNoFillOverride")]
        AllowNoFillOverride,
        /// <summary>
        /// allowNoLineOverride.
        /// <para>When the item is serialized out as xml, its value is "allowNoLineOverride".</para>
        /// </summary>
        [EnumString("allowNoLineOverride")]
        AllowNoLineOverride
    }

    /// <summary>
    /// Defines the MarkerStyle enumeration.
    /// </summary>
    public enum MarkerStyle
    {
        /// <summary>
        /// circle.
        /// <para>When the item is serialized out as xml, its value is "circle".</para>
        /// </summary>
        [EnumString("circle")]
        Circle,
        /// <summary>
        /// dash.
        /// <para>When the item is serialized out as xml, its value is "dash".</para>
        /// </summary>
        [EnumString("dash")]
        Dash,
        /// <summary>
        /// diamond.
        /// <para>When the item is serialized out as xml, its value is "diamond".</para>
        /// </summary>
        [EnumString("diamond")]
        Diamond,
        /// <summary>
        /// dot.
        /// <para>When the item is serialized out as xml, its value is "dot".</para>
        /// </summary>
        [EnumString("dot")]
        Dot,
        /// <summary>
        /// plus.
        /// <para>When the item is serialized out as xml, its value is "plus".</para>
        /// </summary>
        [EnumString("plus")]
        Plus,
        /// <summary>
        /// square.
        /// <para>When the item is serialized out as xml, its value is "square".</para>
        /// </summary>
        [EnumString("square")]
        Square,
        /// <summary>
        /// star.
        /// <para>When the item is serialized out as xml, its value is "star".</para>
        /// </summary>
        [EnumString("star")]
        Star,
        /// <summary>
        /// triangle.
        /// <para>When the item is serialized out as xml, its value is "triangle".</para>
        /// </summary>
        [EnumString("triangle")]
        Triangle,
        /// <summary>
        /// x.
        /// <para>When the item is serialized out as xml, its value is "x".</para>
        /// </summary>
        [EnumString("x")]
        X
    }

    /// <summary>
    /// Defines the Boolean enumeration.
    /// </summary>
    public enum Boolean
    {
        /// <summary>
        /// false.
        /// <para>When the item is serialized out as xml, its value is "false".</para>
        /// </summary>
        [EnumString("false")]
        False,
        /// <summary>
        /// true.
        /// <para>When the item is serialized out as xml, its value is "true".</para>
        /// </summary>
        [EnumString("true")]
        True,
        /// <summary>
        /// ninch.
        /// <para>When the item is serialized out as xml, its value is "ninch".</para>
        /// </summary>
        [EnumString("ninch")]
        Ninch
    }

    /// <summary>
    /// Defines the TickMarkNinch enumeration.
    /// </summary>
    public enum TickMarkNinch
    {
        /// <summary>
        /// cross.
        /// <para>When the item is serialized out as xml, its value is "cross".</para>
        /// </summary>
        [EnumString("cross")]
        Cross,
        /// <summary>
        /// inside.
        /// <para>When the item is serialized out as xml, its value is "inside".</para>
        /// </summary>
        [EnumString("inside")]
        Inside,
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// outside.
        /// <para>When the item is serialized out as xml, its value is "outside".</para>
        /// </summary>
        [EnumString("outside")]
        Outside,
        /// <summary>
        /// ninch.
        /// <para>When the item is serialized out as xml, its value is "ninch".</para>
        /// </summary>
        [EnumString("ninch")]
        Ninch
    }

    /// <summary>
    /// Defines the TickLabelPositionNinch enumeration.
    /// </summary>
    public enum TickLabelPositionNinch
    {
        /// <summary>
        /// high.
        /// <para>When the item is serialized out as xml, its value is "high".</para>
        /// </summary>
        [EnumString("high")]
        High,
        /// <summary>
        /// low.
        /// <para>When the item is serialized out as xml, its value is "low".</para>
        /// </summary>
        [EnumString("low")]
        Low,
        /// <summary>
        /// nextToAxis.
        /// <para>When the item is serialized out as xml, its value is "nextToAxis".</para>
        /// </summary>
        [EnumString("nextToAxis")]
        NextToAxis,
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// ninch.
        /// <para>When the item is serialized out as xml, its value is "ninch".</para>
        /// </summary>
        [EnumString("ninch")]
        Ninch
    }

    /// <summary>
    /// Defines the DataLabelsPosition enumeration.
    /// </summary>
    public enum DataLabelsPosition
    {
        /// <summary>
        /// center.
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// </summary>
        [EnumString("center")]
        Center,
        /// <summary>
        /// insideEnd.
        /// <para>When the item is serialized out as xml, its value is "insideEnd".</para>
        /// </summary>
        [EnumString("insideEnd")]
        InsideEnd,
        /// <summary>
        /// insideBase.
        /// <para>When the item is serialized out as xml, its value is "insideBase".</para>
        /// </summary>
        [EnumString("insideBase")]
        InsideBase,
        /// <summary>
        /// outsideEnd.
        /// <para>When the item is serialized out as xml, its value is "outsideEnd".</para>
        /// </summary>
        [EnumString("outsideEnd")]
        OutsideEnd,
        /// <summary>
        /// ninch.
        /// <para>When the item is serialized out as xml, its value is "ninch".</para>
        /// </summary>
        [EnumString("ninch")]
        Ninch
    }

    /// <summary>
    /// Defines the LegendPosition enumeration.
    /// </summary>
    public enum LegendPosition
    {
        /// <summary>
        /// right.
        /// <para>When the item is serialized out as xml, its value is "right".</para>
        /// </summary>
        [EnumString("right")]
        Right,
        /// <summary>
        /// top.
        /// <para>When the item is serialized out as xml, its value is "top".</para>
        /// </summary>
        [EnumString("top")]
        Top,
        /// <summary>
        /// left.
        /// <para>When the item is serialized out as xml, its value is "left".</para>
        /// </summary>
        [EnumString("left")]
        Left,
        /// <summary>
        /// bottom.
        /// <para>When the item is serialized out as xml, its value is "bottom".</para>
        /// </summary>
        [EnumString("bottom")]
        Bottom,
        /// <summary>
        /// ninch.
        /// <para>When the item is serialized out as xml, its value is "ninch".</para>
        /// </summary>
        [EnumString("ninch")]
        Ninch
    }

    /// <summary>
    /// Defines the TitlePosition enumeration.
    /// </summary>
    public enum TitlePosition
    {
        /// <summary>
        /// above.
        /// <para>When the item is serialized out as xml, its value is "above".</para>
        /// </summary>
        [EnumString("above")]
        Above,
        /// <summary>
        /// overlay.
        /// <para>When the item is serialized out as xml, its value is "overlay".</para>
        /// </summary>
        [EnumString("overlay")]
        Overlay,
        /// <summary>
        /// off.
        /// <para>When the item is serialized out as xml, its value is "off".</para>
        /// </summary>
        [EnumString("off")]
        Off,
        /// <summary>
        /// ninch.
        /// <para>When the item is serialized out as xml, its value is "ninch".</para>
        /// </summary>
        [EnumString("ninch")]
        Ninch
    }
}