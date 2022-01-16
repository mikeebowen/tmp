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

namespace DocumentFormat.OpenXml.Office2021.Drawing.Livefeed
{
    /// <summary>
    /// <para>Defines the BackgroundNormalProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is alf:Normal.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList" /> <c>&lt;alf:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("alf:Normal")]
    public partial class BackgroundNormalProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundNormalProperties class.
        /// </summary>
        public BackgroundNormalProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundNormalProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundNormalProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundNormalProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundNormalProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundNormalProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackgroundNormalProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("alf:Normal");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: alf:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:alf = http://schemas.microsoft.com/office/drawing/2021/livefeed
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundNormalProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the BackgroundRemovedProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is alf:Removed.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList" /> <c>&lt;alf:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("alf:Removed")]
    public partial class BackgroundRemovedProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundRemovedProperties class.
        /// </summary>
        public BackgroundRemovedProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundRemovedProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundRemovedProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundRemovedProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundRemovedProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundRemovedProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackgroundRemovedProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("alf:Removed");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: alf:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:alf = http://schemas.microsoft.com/office/drawing/2021/livefeed
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundRemovedProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the BackgroundBlurProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is alf:Blur.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList" /> <c>&lt;alf:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("alf:Blur")]
    public partial class BackgroundBlurProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundBlurProperties class.
        /// </summary>
        public BackgroundBlurProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundBlurProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundBlurProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundBlurProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundBlurProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundBlurProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackgroundBlurProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("alf:Blur");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: alf:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:alf = http://schemas.microsoft.com/office/drawing/2021/livefeed
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundBlurProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the BackgroundCustomProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is alf:Custom.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList" /> <c>&lt;alf:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("alf:Custom")]
    public partial class BackgroundCustomProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundCustomProperties class.
        /// </summary>
        public BackgroundCustomProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundCustomProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundCustomProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundCustomProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackgroundCustomProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackgroundCustomProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackgroundCustomProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("alf:Custom");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: alf:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:alf = http://schemas.microsoft.com/office/drawing/2021/livefeed
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundCustomProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the LiveFeedProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is alf:liveFeedProps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList" /> <c>&lt;alf:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties" /> <c>&lt;alf:backgroundProps></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("alf:liveFeedProps")]
    public partial class LiveFeedProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LiveFeedProperties class.
        /// </summary>
        public LiveFeedProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LiveFeedProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LiveFeedProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LiveFeedProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LiveFeedProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LiveFeedProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LiveFeedProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("alf:liveFeedProps");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>LiveFeedBackgroundProperties.</para>
        /// <para>Represents the following element tag in the schema: alf:backgroundProps.</para>
        /// </summary>
        /// <remark>
        /// xmlns:alf = http://schemas.microsoft.com/office/drawing/2021/livefeed
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties? LiveFeedBackgroundProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: alf:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:alf = http://schemas.microsoft.com/office/drawing/2021/livefeed
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LiveFeedProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is alf:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("alf:extLst")]
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
            builder.SetSchema("alf:extLst");
            builder.Availability = FileFormatVersions.Office2021;
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
    /// <para>Defines the LiveFeedBackgroundProperties Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is alf:backgroundProps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList" /> <c>&lt;alf:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties" /> <c>&lt;alf:Blur></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties" /> <c>&lt;alf:Custom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties" /> <c>&lt;alf:Normal></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties" /> <c>&lt;alf:Removed></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("alf:backgroundProps")]
    public partial class LiveFeedBackgroundProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LiveFeedBackgroundProperties class.
        /// </summary>
        public LiveFeedBackgroundProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LiveFeedBackgroundProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LiveFeedBackgroundProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LiveFeedBackgroundProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LiveFeedBackgroundProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LiveFeedBackgroundProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LiveFeedBackgroundProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("alf:backgroundProps");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1, version: FileFormatVersions.Office2021)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties), 0, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties), 0, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties), 0, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties), 0, 1, version: FileFormatVersions.Office2021)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LiveFeedBackgroundProperties>(deep);
    }
}