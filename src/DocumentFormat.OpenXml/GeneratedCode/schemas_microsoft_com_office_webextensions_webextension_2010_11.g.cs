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
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
    /// <summary>
    /// <para>Defines the WebExtension Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:webextension.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot" /> <c>&lt;we:snapshot></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList" /> <c>&lt;we:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList" /> <c>&lt;we:bindings></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag" /> <c>&lt;we:properties></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference" /> <c>&lt;we:reference></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList" /> <c>&lt;we:alternateReferences></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("we:webextension")]
    public partial class WebExtension : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtension class.
        /// </summary>
        public WebExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>frozen, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: frozen</para>
        /// </summary>
        [SchemaAttr("frozen")]
        public BooleanValue? Frozen
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:webextension");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>();
            builder.AddElement<WebExtension>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("frozen", a => a.Frozen);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("we:id", 1, 1000) { Application = ApplicationType.Word | ApplicationType.Excel, Version = FileFormatVersions.Office2013 });
        }

        /// <summary>
        /// <para>WebExtensionStoreReference.</para>
        /// <para>Represents the following element tag in the schema: we:reference.</para>
        /// </summary>
        /// <remark>
        /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference? WebExtensionStoreReference
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>WebExtensionReferenceList.</para>
        /// <para>Represents the following element tag in the schema: we:alternateReferences.</para>
        /// </summary>
        /// <remark>
        /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList? WebExtensionReferenceList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionReferenceList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>WebExtensionPropertyBag.</para>
        /// <para>Represents the following element tag in the schema: we:properties.</para>
        /// </summary>
        /// <remark>
        /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag? WebExtensionPropertyBag
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionPropertyBag>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>WebExtensionBindingList.</para>
        /// <para>Represents the following element tag in the schema: we:bindings.</para>
        /// </summary>
        /// <remark>
        /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList? WebExtensionBindingList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBindingList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Snapshot.</para>
        /// <para>Represents the following element tag in the schema: we:snapshot.</para>
        /// </summary>
        /// <remark>
        /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? Snapshot
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: we:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtension>(deep);

        internal WebExtension(WebExtensionPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WebExtensionPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WebExtensionPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WebExtensionPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WebExtensionPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WebExtensionPart associated with this element.
        /// </summary>
        public WebExtensionPart? WebExtensionPart
        {
            get => OpenXmlPart as WebExtensionPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the WebExtensionReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:webextensionref.</para>
    /// </summary>
    [SchemaAttr("we:webextensionref")]
    public partial class WebExtensionReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionReference class.
        /// </summary>
        public WebExtensionReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:webextensionref");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<WebExtensionReference>()
.AddAttribute("r:id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionReference>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionProperty Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:property.</para>
    /// </summary>
    [SchemaAttr("we:property")]
    public partial class WebExtensionProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionProperty class.
        /// </summary>
        public WebExtensionProperty() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public StringValue? Value
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:property");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<WebExtensionProperty>()
.AddAttribute("name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("value", a => a.Value, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("we:extLst")]
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
            builder.SetSchema("we:extLst");
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
    /// <para>Defines the WebExtensionBinding Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:binding.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList" /> <c>&lt;we:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("we:binding")]
    public partial class WebExtensionBinding : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionBinding class.
        /// </summary>
        public WebExtensionBinding() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionBinding class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionBinding(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionBinding class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionBinding(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionBinding class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensionBinding(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public StringValue? Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>appref, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: appref</para>
        /// </summary>
        [SchemaAttr("appref")]
        public StringValue? AppReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:binding");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
            builder.AddElement<WebExtensionBinding>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("appref", a => a.AppReference, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: we:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionBinding>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionStoreReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:reference.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList" /> <c>&lt;we:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("we:reference")]
    public partial class WebExtensionStoreReference : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionStoreReference class.
        /// </summary>
        public WebExtensionStoreReference() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionStoreReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionStoreReference(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionStoreReference class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionStoreReference(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionStoreReference class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensionStoreReference(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>version, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: version</para>
        /// </summary>
        [SchemaAttr("version")]
        public StringValue? Version
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>store, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: store</para>
        /// </summary>
        [SchemaAttr("store")]
        public StringValue? Store
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>storeType, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: storeType</para>
        /// </summary>
        [SchemaAttr("storeType")]
        public StringValue? StoreType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:reference");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
            builder.AddElement<WebExtensionStoreReference>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("version", a => a.Version, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("store", a => a.Store)
.AddAttribute("storeType", a => a.StoreType);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("we:id", 1, 1000) { Application = ApplicationType.Word | ApplicationType.Excel, Version = FileFormatVersions.Office2013 });
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: we:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.WebExtension.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionStoreReference>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionReferenceList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:alternateReferences.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference" /> <c>&lt;we:reference></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("we:alternateReferences")]
    public partial class WebExtensionReferenceList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionReferenceList class.
        /// </summary>
        public WebExtensionReferenceList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionReferenceList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionReferenceList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionReferenceList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionReferenceList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionReferenceList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensionReferenceList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:alternateReferences");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionStoreReference), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionReferenceList>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionPropertyBag Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:properties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty" /> <c>&lt;we:property></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("we:properties")]
    public partial class WebExtensionPropertyBag : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionPropertyBag class.
        /// </summary>
        public WebExtensionPropertyBag() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionPropertyBag class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionPropertyBag(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionPropertyBag class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionPropertyBag(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionPropertyBag class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensionPropertyBag(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:properties");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionProperty), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionPropertyBag>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensionBindingList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:bindings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding" /> <c>&lt;we:binding></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("we:bindings")]
    public partial class WebExtensionBindingList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensionBindingList class.
        /// </summary>
        public WebExtensionBindingList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionBindingList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionBindingList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionBindingList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensionBindingList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensionBindingList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensionBindingList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:bindings");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.WebExtension.WebExtensionBinding), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionBindingList>(deep);
    }

    /// <summary>
    /// <para>Defines the Snapshot Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is we:snapshot.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaBiLevel" /> <c>&lt;a:alphaBiLevel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaCeiling" /> <c>&lt;a:alphaCeiling></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaFloor" /> <c>&lt;a:alphaFloor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaInverse" /> <c>&lt;a:alphaInv></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaModulationEffect" /> <c>&lt;a:alphaMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaModulationFixed" /> <c>&lt;a:alphaModFix></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaReplace" /> <c>&lt;a:alphaRepl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BiLevel" /> <c>&lt;a:biLevel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Blur" /> <c>&lt;a:blur></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ColorChange" /> <c>&lt;a:clrChange></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ColorReplacement" /> <c>&lt;a:clrRepl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Duotone" /> <c>&lt;a:duotone></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FillOverlay" /> <c>&lt;a:fillOverlay></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Grayscale" /> <c>&lt;a:grayscl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Hsl" /> <c>&lt;a:hsl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LuminanceEffect" /> <c>&lt;a:lum></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TintEffect" /> <c>&lt;a:tint></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("we:snapshot")]
    public partial class Snapshot : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Snapshot class.
        /// </summary>
        public Snapshot() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Snapshot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Snapshot(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Snapshot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Snapshot(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Snapshot class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Snapshot(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Embedded Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:embed")]
        public StringValue? Embed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Linked Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:link</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:link")]
        public StringValue? Link
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Compression state for blips.</para>
        /// <para>Represents the following attribute in the schema: cstate</para>
        /// </summary>
        [SchemaAttr("cstate")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>? CompressionState
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("we:snapshot");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blur>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Duotone>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Hsl>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
            builder.AddElement<Snapshot>()
.AddAttribute("r:embed", a => a.Embed)
.AddAttribute("r:link", a => a.Link)
.AddAttribute("cstate", a => a.CompressionState, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaBiLevel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaCeiling), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaFloor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaInverse), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaReplace), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BiLevel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blur), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ColorChange), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ColorReplacement), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Duotone), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillOverlay), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Grayscale), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Hsl), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceEffect), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TintEffect), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Snapshot>(deep);
    }
}