﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2019.Drawing.Animation;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D
{
    /// <summary>
    /// <para>Defines the EmbeddedAnimation Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a3danim:embedAnim.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.OfficeArtExtensionList" /> <c>&lt;a3danim:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.AnimationProperties" /> <c>&lt;a3danim:animPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("a3danim:embedAnim")]
    public partial class EmbeddedAnimation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedAnimation class.
        /// </summary>
        public EmbeddedAnimation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedAnimation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EmbeddedAnimation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedAnimation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EmbeddedAnimation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedAnimation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EmbeddedAnimation(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>animId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: animId</para>
        /// </summary>
        [SchemaAttr("animId")]
        public UInt32Value? AnimId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a3danim:embedAnim");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.AnimationProperties>();
            builder.AddElement<EmbeddedAnimation>()
.AddAttribute("animId", a => a.AnimId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.AnimationProperties), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>AnimationProperties.</para>
        /// <para>Represents the following element tag in the schema: a3danim:animPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a3danim = http://schemas.microsoft.com/office/drawing/2018/animation/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.AnimationProperties? AnimationProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.AnimationProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a3danim:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a3danim = http://schemas.microsoft.com/office/drawing/2018/animation/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EmbeddedAnimation>(deep);
    }

    /// <summary>
    /// <para>Defines the PosterFrame Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a3danim:posterFrame.</para>
    /// </summary>
    [SchemaAttr("a3danim:posterFrame")]
    public partial class PosterFrame : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PosterFrame class.
        /// </summary>
        public PosterFrame() : base()
        {
        }

        /// <summary>
        /// <para>animId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: animId</para>
        /// </summary>
        [SchemaAttr("animId")]
        public UInt32Value? AnimId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>frame, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: frame</para>
        /// </summary>
        [SchemaAttr("frame")]
        public Int32Value? Frame
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a3danim:posterFrame");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<PosterFrame>()
.AddAttribute("animId", a => a.AnimId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("frame", a => a.Frame, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PosterFrame>(deep);
    }

    /// <summary>
    /// <para>Defines the AnimationProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a3danim:animPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList" /> <c>&lt;aanim:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("a3danim:animPr")]
    public partial class AnimationProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimationProperties class.
        /// </summary>
        public AnimationProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimationProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimationProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimationProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnimationProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnimationProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnimationProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>length, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: length</para>
        /// </summary>
        [SchemaAttr("length")]
        public StringValue? Length
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr("count")]
        public StringValue? Count
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>auto, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: auto</para>
        /// </summary>
        [SchemaAttr("auto")]
        public BooleanValue? Auto
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: offset</para>
        /// </summary>
        [SchemaAttr("offset")]
        public StringValue? Offset
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>st, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        [SchemaAttr("st")]
        public StringValue? St
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: end</para>
        /// </summary>
        [SchemaAttr("end")]
        public StringValue? End
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a3danim:animPr");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList>();
            builder.AddElement<AnimationProperties>()
.AddAttribute("name", a => a.Name)
.AddAttribute("length", a => a.Length, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("count", a => a.Count, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<UInt32Value>(NumberValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Indefinite>>(EnumValidator.Instance);
});
})
.AddAttribute("auto", a => a.Auto)
.AddAttribute("offset", a => a.Offset)
.AddAttribute("st", a => a.St)
.AddAttribute("end", a => a.End);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: aanim:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:aanim = http://schemas.microsoft.com/office/drawing/2018/animation
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Animation.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimationProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a3danim:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("a3danim:extLst")]
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
            builder.SetSchema("a3danim:extLst");
            builder.Availability = FileFormatVersions.Office2019;
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
}