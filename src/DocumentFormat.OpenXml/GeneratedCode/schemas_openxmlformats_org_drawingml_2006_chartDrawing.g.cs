﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Drawing.ChartDrawing
{
    /// <summary>
    /// <para>Relative Anchor Shape Size.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:relSizeAnchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape" /> <c>&lt;cdr:cxnSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame" /> <c>&lt;cdr:graphicFrame></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape" /> <c>&lt;cdr:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor" /> <c>&lt;cdr:from></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor" /> <c>&lt;cdr:to></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture" /> <c>&lt;cdr:pic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape" /> <c>&lt;cdr:sp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart" /> <c>&lt;cdr14:contentPart></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:relSizeAnchor")]
    public partial class RelativeAnchorSize : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RelativeAnchorSize class.
        /// </summary>
        public RelativeAnchorSize() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeAnchorSize class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RelativeAnchorSize(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeAnchorSize class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RelativeAnchorSize(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelativeAnchorSize class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RelativeAnchorSize(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:relSizeAnchor");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor), 1, 1),
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                }
            };
        }

        /// <summary>
        /// <para>Starting Anchor Point.</para>
        /// <para>Represents the following element tag in the schema: cdr:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? FromAnchor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Ending Anchor Point.</para>
        /// <para>Represents the following element tag in the schema: cdr:to.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor? ToAnchor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ToAnchor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelativeAnchorSize>(deep);
    }

    /// <summary>
    /// <para>Absolute Anchor Shape Size.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:absSizeAnchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent" /> <c>&lt;cdr:ext></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape" /> <c>&lt;cdr:cxnSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame" /> <c>&lt;cdr:graphicFrame></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape" /> <c>&lt;cdr:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor" /> <c>&lt;cdr:from></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture" /> <c>&lt;cdr:pic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape" /> <c>&lt;cdr:sp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart" /> <c>&lt;cdr14:contentPart></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:absSizeAnchor")]
    public partial class AbsoluteAnchorSize : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchorSize class.
        /// </summary>
        public AbsoluteAnchorSize() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchorSize class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AbsoluteAnchorSize(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchorSize class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AbsoluteAnchorSize(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchorSize class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AbsoluteAnchorSize(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:absSizeAnchor");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent), 1, 1),
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                }
            };
        }

        /// <summary>
        /// <para>FromAnchor.</para>
        /// <para>Represents the following element tag in the schema: cdr:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor? FromAnchor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.FromAnchor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Extent.</para>
        /// <para>Represents the following element tag in the schema: cdr:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent? Extent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsoluteAnchorSize>(deep);
    }

    /// <summary>
    /// <para>Shape Definition.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:sp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cdr:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Style" /> <c>&lt;cdr:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody" /> <c>&lt;cdr:txBody></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties" /> <c>&lt;cdr:nvSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:sp")]
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference to Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        [SchemaAttr("macro")]
        public StringValue? Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Link</para>
        /// <para>Represents the following attribute in the schema: textlink</para>
        /// </summary>
        [SchemaAttr("textlink")]
        public StringValue? TextLink
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Lock Text</para>
        /// <para>Represents the following attribute in the schema: fLocksText</para>
        /// </summary>
        [SchemaAttr("fLocksText")]
        public BooleanValue? LockText
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        [SchemaAttr("fPublished")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:sp");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>();
            builder.AddElement<Shape>()
.AddAttribute("macro", a => a.Macro)
.AddAttribute("textlink", a => a.TextLink)
.AddAttribute("fLocksText", a => a.LockText)
.AddAttribute("fPublished", a => a.Published);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Style), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody), 0, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("cdr:macro", 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:nvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties? NonVisualShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Style.</para>
        /// <para>Represents the following element tag in the schema: cdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.Style? Style
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Text Body.</para>
        /// <para>Represents the following element tag in the schema: cdr:txBody.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? TextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Group Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:grpSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties" /> <c>&lt;cdr:grpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape" /> <c>&lt;cdr:cxnSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame" /> <c>&lt;cdr:graphicFrame></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape" /> <c>&lt;cdr:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties" /> <c>&lt;cdr:nvGrpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture" /> <c>&lt;cdr:pic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape" /> <c>&lt;cdr:sp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart" /> <c>&lt;cdr14:contentPart></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:grpSp")]
    public partial class GroupShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShape class.
        /// </summary>
        public GroupShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShape(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:grpSp");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties), 1, 1),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.GraphicFrame), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.ConnectionShape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <summary>
        /// <para>Non-Visual Group Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:nvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Group Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:grpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? GroupShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShape>(deep);
    }

    /// <summary>
    /// <para>Graphic Frame.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:graphicFrame.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Graphic" /> <c>&lt;a:graphic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform" /> <c>&lt;cdr:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties" /> <c>&lt;cdr:nvGraphicFramePr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:graphicFrame")]
    public partial class GraphicFrame : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrame class.
        /// </summary>
        public GraphicFrame() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrame(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrame(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicFrame(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference to Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        [SchemaAttr("macro")]
        public StringValue? Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish To Server</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        [SchemaAttr("fPublished")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:graphicFrame");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Graphic>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>();
            builder.AddElement<GraphicFrame>()
.AddAttribute("macro", a => a.Macro)
.AddAttribute("fPublished", a => a.Published);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Graphic), 1, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("cdr:macro", 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Graphic Frame Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:nvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Graphic Frame Transform.</para>
        /// <para>Represents the following element tag in the schema: cdr:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform? Transform
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Graphical Object.</para>
        /// <para>Represents the following element tag in the schema: a:graphic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Graphic? Graphic
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrame>(deep);
    }

    /// <summary>
    /// <para>Connection Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:cxnSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cdr:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Style" /> <c>&lt;cdr:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties" /> <c>&lt;cdr:nvCxnSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:cxnSp")]
    public partial class ConnectionShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionShape class.
        /// </summary>
        public ConnectionShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConnectionShape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference to Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        [SchemaAttr("macro")]
        public StringValue? Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        [SchemaAttr("fPublished")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:cxnSp");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>();
            builder.AddElement<ConnectionShape>()
.AddAttribute("macro", a => a.Macro)
.AddAttribute("fPublished", a => a.Published);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Style), 0, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("cdr:macro", 0, 256));
        }

        /// <summary>
        /// <para>Connector Non Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:nvCxnSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectorShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection Shape Style.</para>
        /// <para>Represents the following element tag in the schema: cdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.Style? Style
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectionShape>(deep);
    }

    /// <summary>
    /// <para>Defines the Picture Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:pic.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill" /> <c>&lt;cdr:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties" /> <c>&lt;cdr:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.Style" /> <c>&lt;cdr:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties" /> <c>&lt;cdr:nvPicPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:pic")]
    public partial class Picture : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Picture class.
        /// </summary>
        public Picture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Picture(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference to Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        [SchemaAttr("macro")]
        public StringValue? Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        [SchemaAttr("fPublished")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:pic");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>();
            builder.AddElement<Picture>()
.AddAttribute("macro", a => a.Macro)
.AddAttribute("fPublished", a => a.Published);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.Style), 0, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("cdr:macro", 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Picture Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:nvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties? NonVisualPictureProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Fill.</para>
        /// <para>Represents the following element tag in the schema: cdr:blipFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? BlipFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: cdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Style.</para>
        /// <para>Represents the following element tag in the schema: cdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.Style? Style
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.Style>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Picture>(deep);
    }

    /// <summary>
    /// <para>Chart Non Visual Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnClick" /> <c>&lt;a:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnHover" /> <c>&lt;a:hlinkHover></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:cNvPr")]
    public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class.
        /// </summary>
        public NonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Application defined unique identifier.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Name compatible with Object Model (non-unique).</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description of the drawing element.</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        [SchemaAttr("descr")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Flag determining to show or hide this element.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr("hidden")]
        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:cNvPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProperties>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("descr", a => a.Description)
.AddAttribute("hidden", a => a.Hidden)
.AddAttribute("title", a => a.Title);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(":id", true, null));
        }

        /// <summary>
        /// <para>Hyperlink associated with clicking or selecting the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick? HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlink associated with hovering over the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future extension.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:cNvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapeLocks" /> <c>&lt;a:spLocks></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:cNvSpPr")]
    public partial class NonVisualShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class.
        /// </summary>
        public NonVisualShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Text Box</para>
        /// <para>Represents the following attribute in the schema: txBox</para>
        /// </summary>
        [SchemaAttr("txBox")]
        public BooleanValue? TextBox
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:cNvSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            builder.AddElement<NonVisualShapeDrawingProperties>()
.AddAttribute("txBox", a => a.TextBox);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:spLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ShapeLocks? ShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:nvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties" /> <c>&lt;cdr:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties" /> <c>&lt;cdr:cNvSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:nvSpPr")]
    public partial class NonVisualShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class.
        /// </summary>
        public NonVisualShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:nvSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Chart Non Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:spPr.</para>
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
    [SchemaAttr("cdr:spPr")]
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
            builder.SetSchema("cdr:spPr");
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
    /// <para>Shape Style.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FontReference" /> <c>&lt;a:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LineReference" /> <c>&lt;a:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FillReference" /> <c>&lt;a:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectReference" /> <c>&lt;a:effectRef></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:style")]
    public partial class Style : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Style(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Style(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Style(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:style");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FontReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FontReference), 1, 1)
            };
        }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: a:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineReference? LineReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: a:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FillReference? FillReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: a:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectReference? EffectReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Font Reference.</para>
        /// <para>Represents the following element tag in the schema: a:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FontReference? FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FontReference>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);
    }

    /// <summary>
    /// <para>Shape Text Body.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:txBody.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BodyProperties" /> <c>&lt;a:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ListStyle" /> <c>&lt;a:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Paragraph" /> <c>&lt;a:p></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:txBody")]
    public partial class TextBody : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBody class.
        /// </summary>
        public TextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBody(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:txBody");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <summary>
        /// <para>Body Properties.</para>
        /// <para>Represents the following element tag in the schema: a:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BodyProperties? BodyProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text List Styles.</para>
        /// <para>Represents the following element tag in the schema: a:lstStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ListStyle? ListStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBody>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Connection Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:cNvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.StartConnection" /> <c>&lt;a:stCxn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EndConnection" /> <c>&lt;a:endCxn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks" /> <c>&lt;a:cxnSpLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:cNvCxnSpPr")]
    public partial class NonVisualConnectionShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class.
        /// </summary>
        public NonVisualConnectionShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectionShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectionShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectionShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:cNvCxnSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.StartConnection>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EndConnection>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.StartConnection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EndConnection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Connection Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:cxnSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks? ConnectionShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection Start.</para>
        /// <para>Represents the following element tag in the schema: a:stCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.StartConnection? StartConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.StartConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection End.</para>
        /// <para>Represents the following element tag in the schema: a:endCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EndConnection? EndConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EndConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectionShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Connector Non Visual Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:nvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties" /> <c>&lt;cdr:cNvCxnSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties" /> <c>&lt;cdr:cNvPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:nvCxnSpPr")]
    public partial class NonVisualConnectorShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class.
        /// </summary>
        public NonVisualConnectorShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectorShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:nvCxnSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Chart Non Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Connection Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvCxnSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectorShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Picture Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:cNvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PictureLocks" /> <c>&lt;a:picLocks></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:cNvPicPr")]
    public partial class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class.
        /// </summary>
        public NonVisualPictureDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>preferRelativeResize</para>
        /// <para>Represents the following attribute in the schema: preferRelativeResize</para>
        /// </summary>
        [SchemaAttr("preferRelativeResize")]
        public BooleanValue? PreferRelativeResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:cNvPicPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            builder.AddElement<NonVisualPictureDrawingProperties>()
.AddAttribute("preferRelativeResize", a => a.PreferRelativeResize);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PictureLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>PictureLocks.</para>
        /// <para>Represents the following element tag in the schema: a:picLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PictureLocks? PictureLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualPicturePropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Picture Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:nvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties" /> <c>&lt;cdr:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties" /> <c>&lt;cdr:cNvPicPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:nvPicPr")]
    public partial class NonVisualPictureProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class.
        /// </summary>
        public NonVisualPictureProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:nvPicPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Picture Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureProperties>(deep);
    }

    /// <summary>
    /// <para>Picture Fill.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Blip" /> <c>&lt;a:blip></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SourceRectangle" /> <c>&lt;a:srcRect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Stretch" /> <c>&lt;a:stretch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Tile" /> <c>&lt;a:tile></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:blipFill")]
    public partial class BlipFill : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BlipFill class.
        /// </summary>
        public BlipFill() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BlipFill(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>DPI Setting</para>
        /// <para>Represents the following attribute in the schema: dpi</para>
        /// </summary>
        [SchemaAttr("dpi")]
        public UInt32Value? Dpi
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Rotate With Shape</para>
        /// <para>Represents the following attribute in the schema: rotWithShape</para>
        /// </summary>
        [SchemaAttr("rotWithShape")]
        public BooleanValue? RotateWithShape
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:blipFill");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blip>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Stretch>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Tile>();
            builder.AddElement<BlipFill>()
.AddAttribute("dpi", a => a.Dpi)
.AddAttribute("rotWithShape", a => a.RotateWithShape);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Stretch), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: a:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Blip? Blip
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Blip>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Source Rectangle.</para>
        /// <para>Represents the following element tag in the schema: a:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SourceRectangle? SourceRectangle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipFill>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Graphic Frame Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:cNvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GraphicFrameLocks" /> <c>&lt;a:graphicFrameLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:cNvGraphicFramePr")]
    public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class.
        /// </summary>
        public NonVisualGraphicFrameDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:cNvGraphicFramePr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Graphic Frame Locks.</para>
        /// <para>Represents the following element tag in the schema: a:graphicFrameLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? GraphicFrameLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Graphic Frame Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:nvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties" /> <c>&lt;cdr:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties" /> <c>&lt;cdr:cNvGraphicFramePr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:nvGraphicFramePr")]
    public partial class NonVisualGraphicFrameProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class.
        /// </summary>
        public NonVisualGraphicFrameProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:nvGraphicFramePr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Graphic Frame Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameProperties>(deep);
    }

    /// <summary>
    /// <para>Graphic Frame Transform.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Offset" /> <c>&lt;a:off></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extents" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:xfrm")]
    public partial class Transform : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform class.
        /// </summary>
        public Transform() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transform(string outerXml) : base(outerXml)
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
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>
        [SchemaAttr("flipH")]
        public BooleanValue? HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>
        [SchemaAttr("flipV")]
        public BooleanValue? VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:xfrm");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform>()
.AddAttribute("rot", a => a.Rotation)
.AddAttribute("flipH", a => a.HorizontalFlip)
.AddAttribute("flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
            };
        }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset? Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents? Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Group Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:cNvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupShapeLocks" /> <c>&lt;a:grpSpLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:cNvGrpSpPr")]
    public partial class NonVisualGroupShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class.
        /// </summary>
        public NonVisualGroupShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:cNvGrpSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>GroupShapeLocks.</para>
        /// <para>Represents the following element tag in the schema: a:grpSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GroupShapeLocks? GroupShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGroupDrawingShapePropsExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Relative X Coordinate.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:x.</para>
    /// </summary>
    [SchemaAttr("cdr:x")]
    public partial class XPosition : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the XPosition class.
        /// </summary>
        public XPosition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the XPosition class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public XPosition(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DoubleValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<DoubleValue>(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
            builder.SetSchema("cdr:x");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<XPosition>(deep);
    }

    /// <summary>
    /// <para>Relative Y Coordinate.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:y.</para>
    /// </summary>
    [SchemaAttr("cdr:y")]
    public partial class YPosition : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the YPosition class.
        /// </summary>
        public YPosition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the YPosition class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public YPosition(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new DoubleValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<DoubleValue>(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
            builder.SetSchema("cdr:y");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<YPosition>(deep);
    }

    /// <summary>
    /// <para>Starting Anchor Point.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:from.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition" /> <c>&lt;cdr:x></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition" /> <c>&lt;cdr:y></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:from")]
    public partial class FromAnchor : MarkerType
    {
        /// <summary>
        /// Initializes a new instance of the FromAnchor class.
        /// </summary>
        public FromAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FromAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FromAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FromAnchor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:from");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FromAnchor>(deep);
    }

    /// <summary>
    /// <para>Ending Anchor Point.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:to.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition" /> <c>&lt;cdr:x></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition" /> <c>&lt;cdr:y></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:to")]
    public partial class ToAnchor : MarkerType
    {
        /// <summary>
        /// Initializes a new instance of the ToAnchor class.
        /// </summary>
        public ToAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ToAnchor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:to");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToAnchor>(deep);
    }

    /// <summary>
    /// <para>Defines the MarkerType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition" /> <c>&lt;cdr:x></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition" /> <c>&lt;cdr:y></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class MarkerType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MarkerType class.
        /// </summary>
        protected MarkerType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected MarkerType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected MarkerType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected MarkerType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
        }

        /// <summary>
        /// <para>Relative X Coordinate.</para>
        /// <para>Represents the following element tag in the schema: cdr:x.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition? XPosition
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Relative Y Coordinate.</para>
        /// <para>Represents the following element tag in the schema: cdr:y.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition? YPosition
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Shape Extent.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:ext.</para>
    /// </summary>
    [SchemaAttr("cdr:ext")]
    public partial class Extent : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Extent class.
        /// </summary>
        public Extent() : base()
        {
        }

        /// <summary>
        /// <para>Extent Length</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>
        [SchemaAttr("cx")]
        public Int64Value? Cx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extent Width</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>
        [SchemaAttr("cy")]
        public Int64Value? Cy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:ext");
            builder.AddElement<Extent>()
.AddAttribute("cx", a => a.Cx, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute("cy", a => a.Cy, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extent>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Group Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:nvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties" /> <c>&lt;cdr:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties" /> <c>&lt;cdr:cNvGrpSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:nvGrpSpPr")]
    public partial class NonVisualGroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class.
        /// </summary>
        public NonVisualGroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("cdr:nvGrpSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Chart Non Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Group Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: cdr:cNvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:cdr = http://schemas.openxmlformats.org/drawingml/2006/chartDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Group Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is cdr:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TransformGroup" /> <c>&lt;a:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("cdr:grpSpPr")]
    public partial class GroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class.
        /// </summary>
        public GroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeProperties(string outerXml) : base(outerXml)
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
            builder.SetSchema("cdr:grpSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddElement<GroupShapeProperties>()
.AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup), 0, 1),
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Grouped Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.TransformGroup? TransformGroup
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeProperties>(deep);
    }
}