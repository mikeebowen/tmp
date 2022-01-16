﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.Word
{
    /// <summary>
    /// <para>Defines the TemplateCommandGroup Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:tcg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.AllocatedCommands" /> <c>&lt;wne:acds></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations" /> <c>&lt;wne:keymaps></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization" /> <c>&lt;wne:keymapsBad></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.Toolbars" /> <c>&lt;wne:toolbars></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:tcg")]
    public partial class TemplateCommandGroup : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the TemplateCommandGroup class.
        /// </summary>
        public TemplateCommandGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateCommandGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TemplateCommandGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateCommandGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TemplateCommandGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TemplateCommandGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TemplateCommandGroup(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:tcg");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.Toolbars>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Toolbars), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommands), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TemplateCommandGroup>(deep);

        internal TemplateCommandGroup(CustomizationPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the CustomizationPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(CustomizationPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the CustomizationPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(CustomizationPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the CustomizationPart associated with this element.
        /// </summary>
        public CustomizationPart? CustomizationPart
        {
            get => OpenXmlPart as CustomizationPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the Mcds Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:mcds.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.Mcd" /> <c>&lt;wne:mcd></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:mcds")]
    public partial class Mcds : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Mcds class.
        /// </summary>
        public Mcds() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mcds class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Mcds(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mcds class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Mcds(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mcds class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Mcds(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:mcds");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.Mcd>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Mcd), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mcds>(deep);
    }

    /// <summary>
    /// <para>Defines the VbaSuppData Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:vbaSuppData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.DocEvents" /> <c>&lt;wne:docEvents></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.Mcds" /> <c>&lt;wne:mcds></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:vbaSuppData")]
    public partial class VbaSuppData : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the VbaSuppData class.
        /// </summary>
        public VbaSuppData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VbaSuppData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VbaSuppData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VbaSuppData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VbaSuppData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VbaSuppData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public VbaSuppData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:vbaSuppData");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.DocEvents>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.Mcds>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.DocEvents), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.Mcds), 0, 1)
            };
        }

        /// <summary>
        /// <para>DocEvents.</para>
        /// <para>Represents the following element tag in the schema: wne:docEvents.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.DocEvents? DocEvents
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.DocEvents>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Mcds.</para>
        /// <para>Represents the following element tag in the schema: wne:mcds.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.Mcds? Mcds
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.Mcds>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VbaSuppData>(deep);

        internal VbaSuppData(VbaDataPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the VbaDataPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(VbaDataPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the VbaDataPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(VbaDataPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the VbaDataPart associated with this element.
        /// </summary>
        public VbaDataPart? VbaDataPart
        {
            get => OpenXmlPart as VbaDataPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the MailMergeRecipients Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:recipients.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord" /> <c>&lt;wne:recipientData></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:recipients")]
    public partial class MailMergeRecipients : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the MailMergeRecipients class.
        /// </summary>
        public MailMergeRecipients() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MailMergeRecipients class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MailMergeRecipients(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MailMergeRecipients class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MailMergeRecipients(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MailMergeRecipients class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MailMergeRecipients(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:recipients");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MailMergeRecipients>(deep);
    }

    /// <summary>
    /// <para>Defines the FixedCommandKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:fci.</para>
    /// </summary>
    [SchemaAttr("wne:fci")]
    public partial class FixedCommandKeyboardCustomization : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FixedCommandKeyboardCustomization class.
        /// </summary>
        public FixedCommandKeyboardCustomization() : base()
        {
        }

        /// <summary>
        /// <para>fciName</para>
        /// <para>Represents the following attribute in the schema: wne:fciName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:fciName")]
        public StringValue? CommandName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fciIndex</para>
        /// <para>Represents the following attribute in the schema: wne:fciIndex</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:fciIndex")]
        public HexBinaryValue? CommandIndex
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>swArg</para>
        /// <para>Represents the following attribute in the schema: wne:swArg</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:swArg")]
        public HexBinaryValue? Argument
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:fci");
            builder.AddElement<FixedCommandKeyboardCustomization>()
.AddAttribute("wne:fciName", a => a.CommandName)
.AddAttribute("wne:fciIndex", a => a.CommandIndex, aBuilder =>
{
  aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute("wne:swArg", a => a.Argument, aBuilder =>
{
  aBuilder.AddValidator(new StringValidator() { Length = (2L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FixedCommandKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the MacroKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:macro.</para>
    /// </summary>
    [SchemaAttr("wne:macro")]
    public partial class MacroKeyboardCustomization : MacroWllType
    {
        /// <summary>
        /// Initializes a new instance of the MacroKeyboardCustomization class.
        /// </summary>
        public MacroKeyboardCustomization() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:macro");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MacroKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the WllMacroKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:wll.</para>
    /// </summary>
    [SchemaAttr("wne:wll")]
    public partial class WllMacroKeyboardCustomization : MacroWllType
    {
        /// <summary>
        /// Initializes a new instance of the WllMacroKeyboardCustomization class.
        /// </summary>
        public WllMacroKeyboardCustomization() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:wll");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WllMacroKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the MacroWllType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class MacroWllType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MacroWllType class.
        /// </summary>
        protected MacroWllType() : base()
        {
        }

        /// <summary>
        /// <para>macroName</para>
        /// <para>Represents the following attribute in the schema: wne:macroName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:macroName")]
        public StringValue? MacroName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<MacroWllType>()
                           .AddAttribute("wne:macroName", a => a.MacroName);
        }
    }

    /// <summary>
    /// <para>Defines the AllocatedCommandKeyboardCustomization Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acd.</para>
    /// </summary>
    [SchemaAttr("wne:acd")]
    public partial class AllocatedCommandKeyboardCustomization : AcceleratorKeymapType
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommandKeyboardCustomization class.
        /// </summary>
        public AllocatedCommandKeyboardCustomization() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:acd");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandKeyboardCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommandManifestEntry Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acdEntry.</para>
    /// </summary>
    [SchemaAttr("wne:acdEntry")]
    public partial class AllocatedCommandManifestEntry : AcceleratorKeymapType
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifestEntry class.
        /// </summary>
        public AllocatedCommandManifestEntry() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:acdEntry");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandManifestEntry>(deep);
    }

    /// <summary>
    /// <para>Defines the AcceleratorKeymapType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class AcceleratorKeymapType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AcceleratorKeymapType class.
        /// </summary>
        protected AcceleratorKeymapType() : base()
        {
        }

        /// <summary>
        /// <para>acdName</para>
        /// <para>Represents the following attribute in the schema: wne:acdName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:acdName")]
        public StringValue? AcceleratorName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<AcceleratorKeymapType>()
                           .AddAttribute("wne:acdName", a => a.AcceleratorName);
        }
    }

    /// <summary>
    /// <para>Defines the CharacterInsertion Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:wch.</para>
    /// </summary>
    [SchemaAttr("wne:wch")]
    public partial class CharacterInsertion : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CharacterInsertion class.
        /// </summary>
        public CharacterInsertion() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: wne:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:val")]
        public HexBinaryValue? Val
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:wch");
            builder.AddElement<CharacterInsertion>()
.AddAttribute("wne:val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
  aBuilder.AddValidator(new StringValidator() { Length = (4L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CharacterInsertion>(deep);
    }

    /// <summary>
    /// <para>Defines the KeyMapEntry Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:keymap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization" /> <c>&lt;wne:acd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization" /> <c>&lt;wne:fci></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.CharacterInsertion" /> <c>&lt;wne:wch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization" /> <c>&lt;wne:macro></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization" /> <c>&lt;wne:wll></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:keymap")]
    public partial class KeyMapEntry : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the KeyMapEntry class.
        /// </summary>
        public KeyMapEntry() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public KeyMapEntry(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapEntry class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public KeyMapEntry(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapEntry class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public KeyMapEntry(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>chmPrimary</para>
        /// <para>Represents the following attribute in the schema: wne:chmPrimary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:chmPrimary")]
        public HexBinaryValue? CharacterMapPrimary
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>chmSecondary</para>
        /// <para>Represents the following attribute in the schema: wne:chmSecondary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:chmSecondary")]
        public HexBinaryValue? CharacterMapSecondary
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>kcmPrimary</para>
        /// <para>Represents the following attribute in the schema: wne:kcmPrimary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:kcmPrimary")]
        public HexBinaryValue? KeyCodePrimary
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>kcmSecondary</para>
        /// <para>Represents the following attribute in the schema: wne:kcmSecondary</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:kcmSecondary")]
        public HexBinaryValue? KeyCodeSecondary
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mask</para>
        /// <para>Represents the following attribute in the schema: wne:mask</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:mask")]
        public OnOffValue? Mask
        {
            get => GetAttribute<OnOffValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:keymap");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization>();
            builder.AddElement<KeyMapEntry>()
.AddAttribute("wne:chmPrimary", a => a.CharacterMapPrimary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute("wne:chmSecondary", a => a.CharacterMapSecondary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute("wne:kcmPrimary", a => a.KeyCodePrimary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute("wne:kcmSecondary", a => a.KeyCodeSecondary, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute("wne:mask", a => a.Mask);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.CharacterInsertion), 1, 1)
            };
        }

        /// <summary>
        /// <para>FixedCommandKeyboardCustomization.</para>
        /// <para>Represents the following element tag in the schema: wne:fci.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MacroKeyboardCustomization.</para>
        /// <para>Represents the following element tag in the schema: wne:macro.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization? MacroKeyboardCustomization
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>AllocatedCommandKeyboardCustomization.</para>
        /// <para>Represents the following element tag in the schema: wne:acd.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization? AllocatedCommandKeyboardCustomization
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>WllMacroKeyboardCustomization.</para>
        /// <para>Represents the following element tag in the schema: wne:wll.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization? WllMacroKeyboardCustomization
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CharacterInsertion.</para>
        /// <para>Represents the following element tag in the schema: wne:wch.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.CharacterInsertion? CharacterInsertion
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<KeyMapEntry>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommand Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acd.</para>
    /// </summary>
    [SchemaAttr("wne:acd")]
    public partial class AllocatedCommand : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommand class.
        /// </summary>
        public AllocatedCommand() : base()
        {
        }

        /// <summary>
        /// <para>argValue</para>
        /// <para>Represents the following attribute in the schema: wne:argValue</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:argValue")]
        public StringValue? ArgumentValue
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fciBasedOn</para>
        /// <para>Represents the following attribute in the schema: wne:fciBasedOn</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:fciBasedOn")]
        public StringValue? CommandBasedOn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fciIndexBasedOn</para>
        /// <para>Represents the following attribute in the schema: wne:fciIndexBasedOn</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:fciIndexBasedOn")]
        public HexBinaryValue? CommandIndexBasedOn
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>acdName</para>
        /// <para>Represents the following attribute in the schema: wne:acdName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:acdName")]
        public StringValue? AcceleratorName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:acd");
            builder.AddElement<AllocatedCommand>()
.AddAttribute("wne:argValue", a => a.ArgumentValue)
.AddAttribute("wne:fciBasedOn", a => a.CommandBasedOn)
.AddAttribute("wne:fciIndexBasedOn", a => a.CommandIndexBasedOn, aBuilder =>
{
  aBuilder.AddValidator(new StringValidator() { Length = (2L) });
})
.AddAttribute("wne:acdName", a => a.AcceleratorName);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the Mcd Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:mcd.</para>
    /// </summary>
    [SchemaAttr("wne:mcd")]
    public partial class Mcd : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Mcd class.
        /// </summary>
        public Mcd() : base()
        {
        }

        /// <summary>
        /// <para>macroName</para>
        /// <para>Represents the following attribute in the schema: wne:macroName</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:macroName")]
        public StringValue? MacroName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: wne:name</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>menuHelp</para>
        /// <para>Represents the following attribute in the schema: wne:menuHelp</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:menuHelp")]
        public StringValue? MenuHelp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bEncrypt</para>
        /// <para>Represents the following attribute in the schema: wne:bEncrypt</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:bEncrypt")]
        public HexBinaryValue? BEncrypt
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cmg</para>
        /// <para>Represents the following attribute in the schema: wne:cmg</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:cmg")]
        public HexBinaryValue? Cmg
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:mcd");
            builder.AddElement<Mcd>()
.AddAttribute("wne:macroName", a => a.MacroName)
.AddAttribute("wne:name", a => a.Name)
.AddAttribute("wne:menuHelp", a => a.MenuHelp)
.AddAttribute("wne:bEncrypt", a => a.BEncrypt, aBuilder =>
{
  aBuilder.AddValidator(new StringValidator() { Length = (1L) });
})
.AddAttribute("wne:cmg", a => a.Cmg, aBuilder =>
{
  aBuilder.AddValidator(new StringValidator() { Length = (1L) });
});
            builder.AddConstraint(new AttributeValueLengthConstraint("wne:name", 0, 255) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueSetConstraint("wne:bEncrypt", true, new string[] { "0" }) { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueSetConstraint("wne:cmg", true, new string[] { "56" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mcd>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocNewXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocNew.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocNew")]
    public partial class EventDocNewXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocNewXsdString class.
        /// </summary>
        public EventDocNewXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocNewXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocNewXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocNew");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocNewXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocOpenXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocOpen.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocOpen")]
    public partial class EventDocOpenXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocOpenXsdString class.
        /// </summary>
        public EventDocOpenXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocOpenXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocOpenXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocOpen");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocOpenXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocCloseXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocClose.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocClose")]
    public partial class EventDocCloseXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocCloseXsdString class.
        /// </summary>
        public EventDocCloseXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocCloseXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocCloseXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocClose");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocCloseXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocSyncXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocSync.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocSync")]
    public partial class EventDocSyncXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocSyncXsdString class.
        /// </summary>
        public EventDocSyncXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocSyncXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocSyncXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocSync");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocSyncXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocXmlAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocXmlAfterInsert.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocXmlAfterInsert")]
    public partial class EventDocXmlAfterInsertXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocXmlAfterInsertXsdString class.
        /// </summary>
        public EventDocXmlAfterInsertXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocXmlAfterInsertXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocXmlAfterInsertXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocXmlAfterInsert");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocXmlAfterInsertXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocXmlBeforeDeleteXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocXmlBeforeDelete.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocXmlBeforeDelete")]
    public partial class EventDocXmlBeforeDeleteXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocXmlBeforeDeleteXsdString class.
        /// </summary>
        public EventDocXmlBeforeDeleteXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocXmlBeforeDeleteXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocXmlBeforeDeleteXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocXmlBeforeDelete");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocXmlBeforeDeleteXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlAfterInsert.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocContentControlAfterInsert")]
    public partial class EventDocContentControlAfterInsertXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlAfterInsertXsdString class.
        /// </summary>
        public EventDocContentControlAfterInsertXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlAfterInsertXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlAfterInsertXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocContentControlAfterInsert");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlAfterInsertXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlBeforeDeleteXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlBeforeDelete.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocContentControlBeforeDelete")]
    public partial class EventDocContentControlBeforeDeleteXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlBeforeDeleteXsdString class.
        /// </summary>
        public EventDocContentControlBeforeDeleteXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlBeforeDeleteXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlBeforeDeleteXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocContentControlBeforeDelete");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlBeforeDeleteXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlOnExistXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlOnExit.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocContentControlOnExit")]
    public partial class EventDocContentControlOnExistXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlOnExistXsdString class.
        /// </summary>
        public EventDocContentControlOnExistXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlOnExistXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlOnExistXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocContentControlOnExit");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlOnExistXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlOnEnterXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlOnEnter.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocContentControlOnEnter")]
    public partial class EventDocContentControlOnEnterXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlOnEnterXsdString class.
        /// </summary>
        public EventDocContentControlOnEnterXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlOnEnterXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlOnEnterXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocContentControlOnEnter");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlOnEnterXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocStoreUpdateXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocStoreUpdate.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocStoreUpdate")]
    public partial class EventDocStoreUpdateXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocStoreUpdateXsdString class.
        /// </summary>
        public EventDocStoreUpdateXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocStoreUpdateXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocStoreUpdateXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocStoreUpdate");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocStoreUpdateXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocContentControlUpdateXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocContentControlContentUpdate.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocContentControlContentUpdate")]
    public partial class EventDocContentControlUpdateXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocContentControlUpdateXsdString class.
        /// </summary>
        public EventDocContentControlUpdateXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocContentControlUpdateXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocContentControlUpdateXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocContentControlContentUpdate");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlUpdateXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the EventDocBuildingBlockAfterInsertXsdString Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:eventDocBuildingBlockAfterInsert.</para>
    /// </summary>
    [SchemaAttr("wne:eventDocBuildingBlockAfterInsert")]
    public partial class EventDocBuildingBlockAfterInsertXsdString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the EventDocBuildingBlockAfterInsertXsdString class.
        /// </summary>
        public EventDocBuildingBlockAfterInsertXsdString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EventDocBuildingBlockAfterInsertXsdString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public EventDocBuildingBlockAfterInsertXsdString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:eventDocBuildingBlockAfterInsert");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocBuildingBlockAfterInsertXsdString>(deep);
    }

    /// <summary>
    /// <para>Defines the DocEvents Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:docEvents.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString" /> <c>&lt;wne:eventDocNew></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString" /> <c>&lt;wne:eventDocOpen></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString" /> <c>&lt;wne:eventDocClose></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString" /> <c>&lt;wne:eventDocSync></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString" /> <c>&lt;wne:eventDocXmlAfterInsert></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString" /> <c>&lt;wne:eventDocXmlBeforeDelete></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString" /> <c>&lt;wne:eventDocContentControlAfterInsert></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString" /> <c>&lt;wne:eventDocContentControlBeforeDelete></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString" /> <c>&lt;wne:eventDocContentControlOnExit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString" /> <c>&lt;wne:eventDocContentControlOnEnter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString" /> <c>&lt;wne:eventDocStoreUpdate></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString" /> <c>&lt;wne:eventDocContentControlContentUpdate></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString" /> <c>&lt;wne:eventDocBuildingBlockAfterInsert></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:docEvents")]
    public partial class DocEvents : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DocEvents class.
        /// </summary>
        public DocEvents() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocEvents class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocEvents(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocEvents class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocEvents(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocEvents class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocEvents(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:docEvents");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString), 0, 1)
            };
        }

        /// <summary>
        /// <para>EventDocNewXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocNew.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString? EventDocNewXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocOpenXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocOpen.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString? EventDocOpenXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocCloseXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocClose.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString? EventDocCloseXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocSyncXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocSync.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString? EventDocSyncXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocXmlAfterInsertXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocXmlAfterInsert.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString? EventDocXmlAfterInsertXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocXmlBeforeDeleteXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocXmlBeforeDelete.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString? EventDocXmlBeforeDeleteXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlAfterInsertXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlAfterInsert.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString? EventDocContentControlAfterInsertXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlBeforeDeleteXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlBeforeDelete.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString? EventDocContentControlBeforeDeleteXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlOnExistXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlOnExit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString? EventDocContentControlOnExistXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlOnEnterXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlOnEnter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString? EventDocContentControlOnEnterXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocStoreUpdateXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocStoreUpdate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString? EventDocStoreUpdateXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocContentControlUpdateXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocContentControlContentUpdate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString? EventDocContentControlUpdateXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EventDocBuildingBlockAfterInsertXsdString.</para>
        /// <para>Represents the following element tag in the schema: wne:eventDocBuildingBlockAfterInsert.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString? EventDocBuildingBlockAfterInsertXsdString
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocEvents>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommandManifest Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acdManifest.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry" /> <c>&lt;wne:acdEntry></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:acdManifest")]
    public partial class AllocatedCommandManifest : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifest class.
        /// </summary>
        public AllocatedCommandManifest() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifest class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AllocatedCommandManifest(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifest class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AllocatedCommandManifest(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommandManifest class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AllocatedCommandManifest(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:acdManifest");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifestEntry), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandManifest>(deep);
    }

    /// <summary>
    /// <para>Defines the ToolbarData Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:toolbarData.</para>
    /// </summary>
    [SchemaAttr("wne:toolbarData")]
    public partial class ToolbarData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ToolbarData class.
        /// </summary>
        public ToolbarData() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
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
            builder.SetSchema("wne:toolbarData");
            builder.AddElement<ToolbarData>()
.AddAttribute("r:id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToolbarData>(deep);
    }

    /// <summary>
    /// <para>Defines the KeyMapCustomizations Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:keymaps.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.KeyMapEntry" /> <c>&lt;wne:keymap></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:keymaps")]
    public partial class KeyMapCustomizations : KeymapsType
    {
        /// <summary>
        /// Initializes a new instance of the KeyMapCustomizations class.
        /// </summary>
        public KeyMapCustomizations() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapCustomizations class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public KeyMapCustomizations(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapCustomizations class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public KeyMapCustomizations(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeyMapCustomizations class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public KeyMapCustomizations(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:keymaps");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapEntry), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<KeyMapCustomizations>(deep);
    }

    /// <summary>
    /// <para>Defines the MismatchedKeyMapCustomization Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:keymapsBad.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.KeyMapEntry" /> <c>&lt;wne:keymap></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:keymapsBad")]
    public partial class MismatchedKeyMapCustomization : KeymapsType
    {
        /// <summary>
        /// Initializes a new instance of the MismatchedKeyMapCustomization class.
        /// </summary>
        public MismatchedKeyMapCustomization() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MismatchedKeyMapCustomization class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MismatchedKeyMapCustomization(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MismatchedKeyMapCustomization class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MismatchedKeyMapCustomization(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MismatchedKeyMapCustomization class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MismatchedKeyMapCustomization(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:keymapsBad");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.KeyMapEntry), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MismatchedKeyMapCustomization>(deep);
    }

    /// <summary>
    /// <para>Defines the KeymapsType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.KeyMapEntry" /> <c>&lt;wne:keymap></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class KeymapsType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the KeymapsType class.
        /// </summary>
        protected KeymapsType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeymapsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected KeymapsType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeymapsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected KeymapsType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the KeymapsType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected KeymapsType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.KeyMapEntry>();
        }
    }

    /// <summary>
    /// <para>Defines the Toolbars Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:toolbars.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest" /> <c>&lt;wne:acdManifest></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.ToolbarData" /> <c>&lt;wne:toolbarData></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:toolbars")]
    public partial class Toolbars : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Toolbars class.
        /// </summary>
        public Toolbars() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Toolbars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Toolbars(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Toolbars class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Toolbars(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Toolbars class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Toolbars(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:toolbars");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.ToolbarData>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.ToolbarData), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Toolbars>(deep);
    }

    /// <summary>
    /// <para>Defines the AllocatedCommands Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:acds.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.AllocatedCommand" /> <c>&lt;wne:acd></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:acds")]
    public partial class AllocatedCommands : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AllocatedCommands class.
        /// </summary>
        public AllocatedCommands() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AllocatedCommands(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AllocatedCommands(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AllocatedCommands class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AllocatedCommands(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:acds");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.AllocatedCommand>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.AllocatedCommand), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommands>(deep);
    }

    /// <summary>
    /// <para>Defines the RecordIncluded Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:active.</para>
    /// </summary>
    [SchemaAttr("wne:active")]
    public partial class RecordIncluded : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RecordIncluded class.
        /// </summary>
        public RecordIncluded() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: wne:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:val")]
        public OnOffValue? Val
        {
            get => GetAttribute<OnOffValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:active");
            builder.AddElement<RecordIncluded>()
.AddAttribute("wne:val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecordIncluded>(deep);
    }

    /// <summary>
    /// <para>Defines the RecordHashCode Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:hash.</para>
    /// </summary>
    [SchemaAttr("wne:hash")]
    public partial class RecordHashCode : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RecordHashCode class.
        /// </summary>
        public RecordHashCode() : base()
        {
        }

        /// <summary>
        /// <para>val</para>
        /// <para>Represents the following attribute in the schema: wne:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        [SchemaAttr("wne:val")]
        public IntegerValue? Val
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:hash");
            builder.AddElement<RecordHashCode>()
.AddAttribute("wne:val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecordHashCode>(deep);
    }

    /// <summary>
    /// <para>Defines the SingleDataSourceRecord Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wne:recipientData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.RecordHashCode" /> <c>&lt;wne:hash></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Word.RecordIncluded" /> <c>&lt;wne:active></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wne:recipientData")]
    public partial class SingleDataSourceRecord : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SingleDataSourceRecord class.
        /// </summary>
        public SingleDataSourceRecord() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleDataSourceRecord class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SingleDataSourceRecord(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleDataSourceRecord class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SingleDataSourceRecord(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SingleDataSourceRecord class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SingleDataSourceRecord(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wne:recipientData");
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.RecordHashCode>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Word.RecordIncluded>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.RecordIncluded), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Word.RecordHashCode), 1, 1)
            };
        }

        /// <summary>
        /// <para>RecordIncluded.</para>
        /// <para>Represents the following element tag in the schema: wne:active.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.RecordIncluded? RecordIncluded
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.RecordIncluded>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RecordHashCode.</para>
        /// <para>Represents the following element tag in the schema: wne:hash.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
        /// </remark>
        public DocumentFormat.OpenXml.Office.Word.RecordHashCode? RecordHashCode
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Word.RecordHashCode>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SingleDataSourceRecord>(deep);
    }
}