﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Bibliography
{
    /// <summary>
    /// <para>Sources.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Sources.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Source" /> <c>&lt;b:Source></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Sources")]
    public partial class Sources : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Sources class.
        /// </summary>
        public Sources() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sources class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sources(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sources class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sources(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sources class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Sources(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Selected Style</para>
        /// <para>Represents the following attribute in the schema: SelectedStyle</para>
        /// </summary>
        [SchemaAttr("SelectedStyle")]
        public StringValue? SelectedStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Documentation Style Name</para>
        /// <para>Represents the following attribute in the schema: StyleName</para>
        /// </summary>
        [SchemaAttr("StyleName")]
        public StringValue? StyleName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Uniform Resource Identifier</para>
        /// <para>Represents the following attribute in the schema: URI</para>
        /// </summary>
        [SchemaAttr("URI")]
        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Sources");
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Source>();
            builder.AddElement<Sources>()
.AddAttribute("SelectedStyle", a => a.SelectedStyle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
})
.AddAttribute("StyleName", a => a.StyleName, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
})
.AddAttribute("URI", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Source), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sources>(deep);
    }

    /// <summary>
    /// <para>Person.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Person.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Last" /> <c>&lt;b:Last></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.First" /> <c>&lt;b:First></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Middle" /> <c>&lt;b:Middle></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Person")]
    public partial class Person : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        public Person() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Person(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Person(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Person(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Person");
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Last>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.First>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Middle>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Last), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.First), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Middle), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Person>(deep);
    }

    /// <summary>
    /// <para>Person's Last, or Family, Name.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Last.</para>
    /// </summary>
    [SchemaAttr("b:Last")]
    public partial class Last : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Last class.
        /// </summary>
        public Last() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Last class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Last(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Last");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Last>(deep);
    }

    /// <summary>
    /// <para>Person's First, or Given, Name.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:First.</para>
    /// </summary>
    [SchemaAttr("b:First")]
    public partial class First : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the First class.
        /// </summary>
        public First() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the First class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public First(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:First");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<First>(deep);
    }

    /// <summary>
    /// <para>Person's Middle, or Other, Name.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Middle.</para>
    /// </summary>
    [SchemaAttr("b:Middle")]
    public partial class Middle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Middle class.
        /// </summary>
        public Middle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Middle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Middle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Middle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Middle>(deep);
    }

    /// <summary>
    /// <para>Corporate Author.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Corporate.</para>
    /// </summary>
    [SchemaAttr("b:Corporate")]
    public partial class Corporate : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Corporate class.
        /// </summary>
        public Corporate() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Corporate class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Corporate(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Corporate");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Corporate>(deep);
    }

    /// <summary>
    /// <para>Abbreviated Case Number.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:AbbreviatedCaseNumber.</para>
    /// </summary>
    [SchemaAttr("b:AbbreviatedCaseNumber")]
    public partial class AbbreviatedCaseNumber : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AbbreviatedCaseNumber class.
        /// </summary>
        public AbbreviatedCaseNumber() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbbreviatedCaseNumber class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AbbreviatedCaseNumber(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:AbbreviatedCaseNumber");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbbreviatedCaseNumber>(deep);
    }

    /// <summary>
    /// <para>Album Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:AlbumTitle.</para>
    /// </summary>
    [SchemaAttr("b:AlbumTitle")]
    public partial class AlbumTitle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the AlbumTitle class.
        /// </summary>
        public AlbumTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AlbumTitle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public AlbumTitle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:AlbumTitle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AlbumTitle>(deep);
    }

    /// <summary>
    /// <para>Book Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:BookTitle.</para>
    /// </summary>
    [SchemaAttr("b:BookTitle")]
    public partial class BookTitle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the BookTitle class.
        /// </summary>
        public BookTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BookTitle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public BookTitle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:BookTitle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BookTitle>(deep);
    }

    /// <summary>
    /// <para>Broadcaster.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Broadcaster.</para>
    /// </summary>
    [SchemaAttr("b:Broadcaster")]
    public partial class Broadcaster : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Broadcaster class.
        /// </summary>
        public Broadcaster() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Broadcaster class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Broadcaster(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Broadcaster");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Broadcaster>(deep);
    }

    /// <summary>
    /// <para>Broadcast Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:BroadcastTitle.</para>
    /// </summary>
    [SchemaAttr("b:BroadcastTitle")]
    public partial class BroadcastTitle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the BroadcastTitle class.
        /// </summary>
        public BroadcastTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BroadcastTitle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public BroadcastTitle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:BroadcastTitle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BroadcastTitle>(deep);
    }

    /// <summary>
    /// <para>Case Number.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:CaseNumber.</para>
    /// </summary>
    [SchemaAttr("b:CaseNumber")]
    public partial class CaseNumber : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CaseNumber class.
        /// </summary>
        public CaseNumber() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CaseNumber class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CaseNumber(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:CaseNumber");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CaseNumber>(deep);
    }

    /// <summary>
    /// <para>Chapter Number.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:ChapterNumber.</para>
    /// </summary>
    [SchemaAttr("b:ChapterNumber")]
    public partial class ChapterNumber : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ChapterNumber class.
        /// </summary>
        public ChapterNumber() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChapterNumber class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ChapterNumber(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:ChapterNumber");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChapterNumber>(deep);
    }

    /// <summary>
    /// <para>City.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:City.</para>
    /// </summary>
    [SchemaAttr("b:City")]
    public partial class City : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the City class.
        /// </summary>
        public City() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the City class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public City(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:City");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<City>(deep);
    }

    /// <summary>
    /// <para>Comments.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Comments.</para>
    /// </summary>
    [SchemaAttr("b:Comments")]
    public partial class Comments : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Comments class.
        /// </summary>
        public Comments() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comments class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Comments(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Comments");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Comments>(deep);
    }

    /// <summary>
    /// <para>Conference or Proceedings Name.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:ConferenceName.</para>
    /// </summary>
    [SchemaAttr("b:ConferenceName")]
    public partial class ConferenceName : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ConferenceName class.
        /// </summary>
        public ConferenceName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConferenceName class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ConferenceName(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:ConferenceName");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConferenceName>(deep);
    }

    /// <summary>
    /// <para>Country or Region.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:CountryRegion.</para>
    /// </summary>
    [SchemaAttr("b:CountryRegion")]
    public partial class CountryRegion : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CountryRegion class.
        /// </summary>
        public CountryRegion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CountryRegion class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CountryRegion(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:CountryRegion");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CountryRegion>(deep);
    }

    /// <summary>
    /// <para>Court.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Court.</para>
    /// </summary>
    [SchemaAttr("b:Court")]
    public partial class Court : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Court class.
        /// </summary>
        public Court() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Court class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Court(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Court");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Court>(deep);
    }

    /// <summary>
    /// <para>Day.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Day.</para>
    /// </summary>
    [SchemaAttr("b:Day")]
    public partial class Day : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Day class.
        /// </summary>
        public Day() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Day class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Day(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Day");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Day>(deep);
    }

    /// <summary>
    /// <para>Day Accessed.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:DayAccessed.</para>
    /// </summary>
    [SchemaAttr("b:DayAccessed")]
    public partial class DayAccessed : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DayAccessed class.
        /// </summary>
        public DayAccessed() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DayAccessed class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DayAccessed(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:DayAccessed");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DayAccessed>(deep);
    }

    /// <summary>
    /// <para>Department.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Department.</para>
    /// </summary>
    [SchemaAttr("b:Department")]
    public partial class Department : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Department class.
        /// </summary>
        public Department() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Department class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Department(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Department");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Department>(deep);
    }

    /// <summary>
    /// <para>Distributor.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Distributor.</para>
    /// </summary>
    [SchemaAttr("b:Distributor")]
    public partial class Distributor : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Distributor class.
        /// </summary>
        public Distributor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Distributor class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Distributor(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Distributor");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Distributor>(deep);
    }

    /// <summary>
    /// <para>Editor.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Edition.</para>
    /// </summary>
    [SchemaAttr("b:Edition")]
    public partial class Edition : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Edition class.
        /// </summary>
        public Edition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Edition class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Edition(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Edition");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Edition>(deep);
    }

    /// <summary>
    /// <para>GUID.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Guid.</para>
    /// </summary>
    [SchemaAttr("b:Guid")]
    public partial class GuidString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the GuidString class.
        /// </summary>
        public GuidString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GuidString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public GuidString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Guid");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GuidString>(deep);
    }

    /// <summary>
    /// <para>Institution.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Institution.</para>
    /// </summary>
    [SchemaAttr("b:Institution")]
    public partial class Institution : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Institution class.
        /// </summary>
        public Institution() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Institution class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Institution(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Institution");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Institution>(deep);
    }

    /// <summary>
    /// <para>Internet Site Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:InternetSiteTitle.</para>
    /// </summary>
    [SchemaAttr("b:InternetSiteTitle")]
    public partial class InternetSiteTitle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the InternetSiteTitle class.
        /// </summary>
        public InternetSiteTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InternetSiteTitle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public InternetSiteTitle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:InternetSiteTitle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InternetSiteTitle>(deep);
    }

    /// <summary>
    /// <para>Issue.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Issue.</para>
    /// </summary>
    [SchemaAttr("b:Issue")]
    public partial class Issue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Issue class.
        /// </summary>
        public Issue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Issue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Issue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Issue");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Issue>(deep);
    }

    /// <summary>
    /// <para>Journal Name.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:JournalName.</para>
    /// </summary>
    [SchemaAttr("b:JournalName")]
    public partial class JournalName : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the JournalName class.
        /// </summary>
        public JournalName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the JournalName class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public JournalName(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:JournalName");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<JournalName>(deep);
    }

    /// <summary>
    /// <para>Locale ID.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:LCID.</para>
    /// </summary>
    [SchemaAttr("b:LCID")]
    public partial class LcId : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LcId class.
        /// </summary>
        public LcId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LcId class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LcId(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:LCID");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LcId>(deep);
    }

    /// <summary>
    /// <para>Medium.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Medium.</para>
    /// </summary>
    [SchemaAttr("b:Medium")]
    public partial class Medium : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Medium class.
        /// </summary>
        public Medium() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Medium class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Medium(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Medium");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Medium>(deep);
    }

    /// <summary>
    /// <para>Month.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Month.</para>
    /// </summary>
    [SchemaAttr("b:Month")]
    public partial class Month : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Month class.
        /// </summary>
        public Month() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Month class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Month(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Month");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Month>(deep);
    }

    /// <summary>
    /// <para>Month Accessed.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:MonthAccessed.</para>
    /// </summary>
    [SchemaAttr("b:MonthAccessed")]
    public partial class MonthAccessed : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the MonthAccessed class.
        /// </summary>
        public MonthAccessed() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MonthAccessed class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public MonthAccessed(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:MonthAccessed");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MonthAccessed>(deep);
    }

    /// <summary>
    /// <para>Number of Volumes.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:NumberVolumes.</para>
    /// </summary>
    [SchemaAttr("b:NumberVolumes")]
    public partial class NumberVolumes : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberVolumes class.
        /// </summary>
        public NumberVolumes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberVolumes class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public NumberVolumes(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:NumberVolumes");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberVolumes>(deep);
    }

    /// <summary>
    /// <para>Pages.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Pages.</para>
    /// </summary>
    [SchemaAttr("b:Pages")]
    public partial class Pages : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Pages class.
        /// </summary>
        public Pages() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pages class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Pages(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Pages");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pages>(deep);
    }

    /// <summary>
    /// <para>Patent Number.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:PatentNumber.</para>
    /// </summary>
    [SchemaAttr("b:PatentNumber")]
    public partial class PatentNumber : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PatentNumber class.
        /// </summary>
        public PatentNumber() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PatentNumber class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PatentNumber(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:PatentNumber");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PatentNumber>(deep);
    }

    /// <summary>
    /// <para>Periodical Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:PeriodicalTitle.</para>
    /// </summary>
    [SchemaAttr("b:PeriodicalTitle")]
    public partial class PeriodicalTitle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PeriodicalTitle class.
        /// </summary>
        public PeriodicalTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PeriodicalTitle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PeriodicalTitle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:PeriodicalTitle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PeriodicalTitle>(deep);
    }

    /// <summary>
    /// <para>Production Company.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:ProductionCompany.</para>
    /// </summary>
    [SchemaAttr("b:ProductionCompany")]
    public partial class ProductionCompany : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ProductionCompany class.
        /// </summary>
        public ProductionCompany() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProductionCompany class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ProductionCompany(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:ProductionCompany");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ProductionCompany>(deep);
    }

    /// <summary>
    /// <para>Publication Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:PublicationTitle.</para>
    /// </summary>
    [SchemaAttr("b:PublicationTitle")]
    public partial class PublicationTitle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PublicationTitle class.
        /// </summary>
        public PublicationTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PublicationTitle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PublicationTitle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:PublicationTitle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PublicationTitle>(deep);
    }

    /// <summary>
    /// <para>Publisher.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Publisher.</para>
    /// </summary>
    [SchemaAttr("b:Publisher")]
    public partial class Publisher : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Publisher class.
        /// </summary>
        public Publisher() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Publisher class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Publisher(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Publisher");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Publisher>(deep);
    }

    /// <summary>
    /// <para>Recording Number.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:RecordingNumber.</para>
    /// </summary>
    [SchemaAttr("b:RecordingNumber")]
    public partial class RecordingNumber : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RecordingNumber class.
        /// </summary>
        public RecordingNumber() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RecordingNumber class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RecordingNumber(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:RecordingNumber");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecordingNumber>(deep);
    }

    /// <summary>
    /// <para>Reference Order.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:RefOrder.</para>
    /// </summary>
    [SchemaAttr("b:RefOrder")]
    public partial class ReferenceOrder : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ReferenceOrder class.
        /// </summary>
        public ReferenceOrder() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ReferenceOrder class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ReferenceOrder(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:RefOrder");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ReferenceOrder>(deep);
    }

    /// <summary>
    /// <para>Reporter.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Reporter.</para>
    /// </summary>
    [SchemaAttr("b:Reporter")]
    public partial class Reporter : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Reporter class.
        /// </summary>
        public Reporter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Reporter class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Reporter(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Reporter");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Reporter>(deep);
    }

    /// <summary>
    /// <para>Short Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:ShortTitle.</para>
    /// </summary>
    [SchemaAttr("b:ShortTitle")]
    public partial class ShortTitle : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ShortTitle class.
        /// </summary>
        public ShortTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShortTitle class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ShortTitle(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:ShortTitle");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShortTitle>(deep);
    }

    /// <summary>
    /// <para>Standard Number.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:StandardNumber.</para>
    /// </summary>
    [SchemaAttr("b:StandardNumber")]
    public partial class StandardNumber : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the StandardNumber class.
        /// </summary>
        public StandardNumber() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StandardNumber class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public StandardNumber(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:StandardNumber");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StandardNumber>(deep);
    }

    /// <summary>
    /// <para>State or Province.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:StateProvince.</para>
    /// </summary>
    [SchemaAttr("b:StateProvince")]
    public partial class StateProvince : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the StateProvince class.
        /// </summary>
        public StateProvince() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateProvince class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public StateProvince(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:StateProvince");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StateProvince>(deep);
    }

    /// <summary>
    /// <para>Station.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Station.</para>
    /// </summary>
    [SchemaAttr("b:Station")]
    public partial class Station : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Station class.
        /// </summary>
        public Station() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Station class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Station(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Station");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Station>(deep);
    }

    /// <summary>
    /// <para>Tag.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Tag.</para>
    /// </summary>
    [SchemaAttr("b:Tag")]
    public partial class Tag : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Tag class.
        /// </summary>
        public Tag() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Tag(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Tag");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tag>(deep);
    }

    /// <summary>
    /// <para>Theater.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Theater.</para>
    /// </summary>
    [SchemaAttr("b:Theater")]
    public partial class Theater : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Theater class.
        /// </summary>
        public Theater() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Theater class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Theater(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Theater");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Theater>(deep);
    }

    /// <summary>
    /// <para>Thesis Type.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:ThesisType.</para>
    /// </summary>
    [SchemaAttr("b:ThesisType")]
    public partial class ThesisType : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ThesisType class.
        /// </summary>
        public ThesisType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThesisType class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ThesisType(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:ThesisType");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThesisType>(deep);
    }

    /// <summary>
    /// <para>Title.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Title.</para>
    /// </summary>
    [SchemaAttr("b:Title")]
    public partial class Title : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Title class.
        /// </summary>
        public Title() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Title class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Title(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Title");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Title>(deep);
    }

    /// <summary>
    /// <para>Type.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Type.</para>
    /// </summary>
    [SchemaAttr("b:Type")]
    public partial class PatentType : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PatentType class.
        /// </summary>
        public PatentType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PatentType class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PatentType(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Type");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PatentType>(deep);
    }

    /// <summary>
    /// <para>URL.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:URL.</para>
    /// </summary>
    [SchemaAttr("b:URL")]
    public partial class UrlString : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the UrlString class.
        /// </summary>
        public UrlString() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UrlString class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public UrlString(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:URL");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UrlString>(deep);
    }

    /// <summary>
    /// <para>Version.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Version.</para>
    /// </summary>
    [SchemaAttr("b:Version")]
    public partial class Version : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Version class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Version(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Version");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Version>(deep);
    }

    /// <summary>
    /// <para>Volume.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Volume.</para>
    /// </summary>
    [SchemaAttr("b:Volume")]
    public partial class Volume : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        public Volume() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Volume class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Volume(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Volume");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Volume>(deep);
    }

    /// <summary>
    /// <para>Year.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Year.</para>
    /// </summary>
    [SchemaAttr("b:Year")]
    public partial class Year : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Year class.
        /// </summary>
        public Year() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Year class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Year(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:Year");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Year>(deep);
    }

    /// <summary>
    /// <para>Year Accessed.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:YearAccessed.</para>
    /// </summary>
    [SchemaAttr("b:YearAccessed")]
    public partial class YearAccessed : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the YearAccessed class.
        /// </summary>
        public YearAccessed() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the YearAccessed class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public YearAccessed(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator(new StringValidator() { MinLength = (0L), MaxLength = (255L) });
            builder.SetSchema("b:YearAccessed");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<YearAccessed>(deep);
    }

    /// <summary>
    /// <para>Name List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:NameList.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Person" /> <c>&lt;b:Person></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:NameList")]
    public partial class NameList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NameList class.
        /// </summary>
        public NameList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NameList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NameList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NameList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:NameList");
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Person>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Person), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NameList>(deep);
    }

    /// <summary>
    /// <para>Artist.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Artist.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Artist")]
    public partial class Artist : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Artist class.
        /// </summary>
        public Artist() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Artist class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Artist(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Artist class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Artist(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Artist class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Artist(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Artist");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Artist>(deep);
    }

    /// <summary>
    /// <para>Book Author.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:BookAuthor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:BookAuthor")]
    public partial class BookAuthor : NameType
    {
        /// <summary>
        /// Initializes a new instance of the BookAuthor class.
        /// </summary>
        public BookAuthor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BookAuthor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BookAuthor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BookAuthor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BookAuthor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BookAuthor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BookAuthor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:BookAuthor");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BookAuthor>(deep);
    }

    /// <summary>
    /// <para>Compiler.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Compiler.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Compiler")]
    public partial class Compiler : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Compiler class.
        /// </summary>
        public Compiler() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Compiler class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Compiler(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Compiler class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Compiler(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Compiler class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Compiler(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Compiler");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Compiler>(deep);
    }

    /// <summary>
    /// <para>Composer.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Composer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Composer")]
    public partial class Composer : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Composer class.
        /// </summary>
        public Composer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Composer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Composer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Composer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Composer(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Composer class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Composer(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Composer");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Composer>(deep);
    }

    /// <summary>
    /// <para>Conductor.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Conductor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Conductor")]
    public partial class Conductor : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Conductor class.
        /// </summary>
        public Conductor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Conductor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Conductor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Conductor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Conductor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Conductor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Conductor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Conductor");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Conductor>(deep);
    }

    /// <summary>
    /// <para>Counsel.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Counsel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Counsel")]
    public partial class Counsel : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Counsel class.
        /// </summary>
        public Counsel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Counsel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Counsel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Counsel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Counsel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Counsel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Counsel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Counsel");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Counsel>(deep);
    }

    /// <summary>
    /// <para>Director.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Director.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Director")]
    public partial class Director : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Director class.
        /// </summary>
        public Director() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Director class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Director(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Director class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Director(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Director class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Director(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Director");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Director>(deep);
    }

    /// <summary>
    /// <para>Editor.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Editor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Editor")]
    public partial class Editor : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Editor class.
        /// </summary>
        public Editor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Editor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Editor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Editor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Editor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Editor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Editor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Editor");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Editor>(deep);
    }

    /// <summary>
    /// <para>Interviewee.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Interviewee.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Interviewee")]
    public partial class Interviewee : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Interviewee class.
        /// </summary>
        public Interviewee() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interviewee class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Interviewee(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interviewee class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Interviewee(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interviewee class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Interviewee(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Interviewee");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Interviewee>(deep);
    }

    /// <summary>
    /// <para>Interviewer.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Interviewer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Interviewer")]
    public partial class Interviewer : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Interviewer class.
        /// </summary>
        public Interviewer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interviewer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Interviewer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interviewer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Interviewer(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interviewer class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Interviewer(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Interviewer");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Interviewer>(deep);
    }

    /// <summary>
    /// <para>Inventor.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Inventor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Inventor")]
    public partial class Inventor : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Inventor class.
        /// </summary>
        public Inventor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Inventor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Inventor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Inventor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Inventor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Inventor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Inventor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Inventor");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Inventor>(deep);
    }

    /// <summary>
    /// <para>Producer Name.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:ProducerName.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:ProducerName")]
    public partial class ProducerName : NameType
    {
        /// <summary>
        /// Initializes a new instance of the ProducerName class.
        /// </summary>
        public ProducerName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProducerName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ProducerName(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProducerName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ProducerName(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ProducerName class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ProducerName(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:ProducerName");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ProducerName>(deep);
    }

    /// <summary>
    /// <para>Translator.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Translator.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Translator")]
    public partial class Translator : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Translator class.
        /// </summary>
        public Translator() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Translator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Translator(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Translator class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Translator(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Translator class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Translator(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Translator");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Translator>(deep);
    }

    /// <summary>
    /// <para>Writer.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Writer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Writer")]
    public partial class Writer : NameType
    {
        /// <summary>
        /// Initializes a new instance of the Writer class.
        /// </summary>
        public Writer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Writer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Writer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Writer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Writer(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Writer class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Writer(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Writer");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Writer>(deep);
    }

    /// <summary>
    /// <para>Defines the NameType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class NameType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NameType class.
        /// </summary>
        protected NameType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected NameType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected NameType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected NameType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.NameList>();
        }

        /// <summary>
        /// <para>Name List.</para>
        /// <para>Represents the following element tag in the schema: b:NameList.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.NameList? NameList
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.NameList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Author.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Author.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Corporate" /> <c>&lt;b:Corporate></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Author")]
    public partial class Author : NameOrCorporateType
    {
        /// <summary>
        /// Initializes a new instance of the Author class.
        /// </summary>
        public Author() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Author class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Author(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Author class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Author(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Author class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Author(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Author");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Corporate), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Author>(deep);
    }

    /// <summary>
    /// <para>Performer.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Performer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Corporate" /> <c>&lt;b:Corporate></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Performer")]
    public partial class Performer : NameOrCorporateType
    {
        /// <summary>
        /// Initializes a new instance of the Performer class.
        /// </summary>
        public Performer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Performer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Performer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Performer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Performer(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Performer class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Performer(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Performer");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NameList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Corporate), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Performer>(deep);
    }

    /// <summary>
    /// <para>Defines the NameOrCorporateType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NameList" /> <c>&lt;b:NameList></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Corporate" /> <c>&lt;b:Corporate></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class NameOrCorporateType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NameOrCorporateType class.
        /// </summary>
        protected NameOrCorporateType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameOrCorporateType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected NameOrCorporateType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameOrCorporateType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected NameOrCorporateType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NameOrCorporateType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected NameOrCorporateType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.NameList>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Corporate>();
        }

        /// <summary>
        /// <para>NameList.</para>
        /// <para>Represents the following element tag in the schema: b:NameList.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.NameList? NameList
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.NameList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Corporate Author.</para>
        /// <para>Represents the following element tag in the schema: b:Corporate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Corporate? Corporate
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Corporate>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Contributors List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Author.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Author" /> <c>&lt;b:Author></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Performer" /> <c>&lt;b:Performer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Artist" /> <c>&lt;b:Artist></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.BookAuthor" /> <c>&lt;b:BookAuthor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Compiler" /> <c>&lt;b:Compiler></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Composer" /> <c>&lt;b:Composer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Conductor" /> <c>&lt;b:Conductor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Counsel" /> <c>&lt;b:Counsel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Director" /> <c>&lt;b:Director></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Editor" /> <c>&lt;b:Editor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Interviewee" /> <c>&lt;b:Interviewee></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Interviewer" /> <c>&lt;b:Interviewer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Inventor" /> <c>&lt;b:Inventor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.ProducerName" /> <c>&lt;b:ProducerName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Translator" /> <c>&lt;b:Translator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Writer" /> <c>&lt;b:Writer></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Author")]
    public partial class AuthorList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AuthorList class.
        /// </summary>
        public AuthorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AuthorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AuthorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AuthorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AuthorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AuthorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AuthorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Author");
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Author>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Performer>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Artist>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.BookAuthor>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Compiler>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Composer>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Conductor>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Counsel>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Director>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Editor>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Interviewee>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Interviewer>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Inventor>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.ProducerName>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Translator>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Writer>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Artist), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Author), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.BookAuthor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Compiler), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Composer), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Conductor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Counsel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Director), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Editor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Interviewee), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Interviewer), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Inventor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Performer), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.ProducerName), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Translator), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Writer), 1, 1)
                }
            };
        }

        /// <summary>
        /// <para>Artist.</para>
        /// <para>Represents the following element tag in the schema: b:Artist.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Artist? Artist
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Artist>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Author.</para>
        /// <para>Represents the following element tag in the schema: b:Author.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Author? Author
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Author>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Book Author.</para>
        /// <para>Represents the following element tag in the schema: b:BookAuthor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.BookAuthor? BookAuthor
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.BookAuthor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Compiler.</para>
        /// <para>Represents the following element tag in the schema: b:Compiler.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Compiler? Compiler
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Compiler>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Composer.</para>
        /// <para>Represents the following element tag in the schema: b:Composer.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Composer? Composer
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Composer>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Conductor.</para>
        /// <para>Represents the following element tag in the schema: b:Conductor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Conductor? Conductor
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Conductor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Counsel.</para>
        /// <para>Represents the following element tag in the schema: b:Counsel.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Counsel? Counsel
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Counsel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Director.</para>
        /// <para>Represents the following element tag in the schema: b:Director.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Director? Director
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Director>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Editor.</para>
        /// <para>Represents the following element tag in the schema: b:Editor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Editor? Editor
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Editor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Interviewee.</para>
        /// <para>Represents the following element tag in the schema: b:Interviewee.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Interviewee? Interviewee
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Interviewee>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Interviewer.</para>
        /// <para>Represents the following element tag in the schema: b:Interviewer.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Interviewer? Interviewer
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Interviewer>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Inventor.</para>
        /// <para>Represents the following element tag in the schema: b:Inventor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Inventor? Inventor
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Inventor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Performer.</para>
        /// <para>Represents the following element tag in the schema: b:Performer.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Performer? Performer
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Performer>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Producer Name.</para>
        /// <para>Represents the following element tag in the schema: b:ProducerName.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.ProducerName? ProducerName
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.ProducerName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Translator.</para>
        /// <para>Represents the following element tag in the schema: b:Translator.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Translator? Translator
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Translator>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Writer.</para>
        /// <para>Represents the following element tag in the schema: b:Writer.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Writer? Writer
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Writer>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AuthorList>(deep);
    }

    /// <summary>
    /// <para>Source Type.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:SourceType.</para>
    /// </summary>
    [SchemaAttr("b:SourceType")]
    public partial class SourceType : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SourceType class.
        /// </summary>
        public SourceType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SourceType class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SourceType(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new EnumValue<DocumentFormat.OpenXml.Bibliography.DataSourceValues> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<EnumValue<DocumentFormat.OpenXml.Bibliography.DataSourceValues>>(EnumValidator.Instance);
            builder.SetSchema("b:SourceType");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SourceType>(deep);
    }

    /// <summary>
    /// <para>Source.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is b:Source.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.AuthorList" /> <c>&lt;b:Author></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.SourceType" /> <c>&lt;b:SourceType></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.AbbreviatedCaseNumber" /> <c>&lt;b:AbbreviatedCaseNumber></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.AlbumTitle" /> <c>&lt;b:AlbumTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.BookTitle" /> <c>&lt;b:BookTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Broadcaster" /> <c>&lt;b:Broadcaster></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.BroadcastTitle" /> <c>&lt;b:BroadcastTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.CaseNumber" /> <c>&lt;b:CaseNumber></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.ChapterNumber" /> <c>&lt;b:ChapterNumber></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.City" /> <c>&lt;b:City></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Comments" /> <c>&lt;b:Comments></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.ConferenceName" /> <c>&lt;b:ConferenceName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.CountryRegion" /> <c>&lt;b:CountryRegion></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Court" /> <c>&lt;b:Court></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Day" /> <c>&lt;b:Day></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.DayAccessed" /> <c>&lt;b:DayAccessed></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Department" /> <c>&lt;b:Department></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Distributor" /> <c>&lt;b:Distributor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Edition" /> <c>&lt;b:Edition></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.GuidString" /> <c>&lt;b:Guid></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Institution" /> <c>&lt;b:Institution></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.InternetSiteTitle" /> <c>&lt;b:InternetSiteTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Issue" /> <c>&lt;b:Issue></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.JournalName" /> <c>&lt;b:JournalName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.LcId" /> <c>&lt;b:LCID></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Medium" /> <c>&lt;b:Medium></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Month" /> <c>&lt;b:Month></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.MonthAccessed" /> <c>&lt;b:MonthAccessed></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.NumberVolumes" /> <c>&lt;b:NumberVolumes></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Pages" /> <c>&lt;b:Pages></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.PatentNumber" /> <c>&lt;b:PatentNumber></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.PeriodicalTitle" /> <c>&lt;b:PeriodicalTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.ProductionCompany" /> <c>&lt;b:ProductionCompany></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.PublicationTitle" /> <c>&lt;b:PublicationTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Publisher" /> <c>&lt;b:Publisher></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.RecordingNumber" /> <c>&lt;b:RecordingNumber></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.ReferenceOrder" /> <c>&lt;b:RefOrder></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Reporter" /> <c>&lt;b:Reporter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.ShortTitle" /> <c>&lt;b:ShortTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.StandardNumber" /> <c>&lt;b:StandardNumber></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.StateProvince" /> <c>&lt;b:StateProvince></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Station" /> <c>&lt;b:Station></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Tag" /> <c>&lt;b:Tag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Theater" /> <c>&lt;b:Theater></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.ThesisType" /> <c>&lt;b:ThesisType></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Title" /> <c>&lt;b:Title></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.PatentType" /> <c>&lt;b:Type></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.UrlString" /> <c>&lt;b:URL></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Version" /> <c>&lt;b:Version></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Volume" /> <c>&lt;b:Volume></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.Year" /> <c>&lt;b:Year></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Bibliography.YearAccessed" /> <c>&lt;b:YearAccessed></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("b:Source")]
    public partial class Source : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Source class.
        /// </summary>
        public Source() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Source class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Source(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Source class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Source(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Source class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Source(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("b:Source");
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.AuthorList>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.SourceType>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.AbbreviatedCaseNumber>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.AlbumTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.BookTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Broadcaster>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.BroadcastTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.CaseNumber>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.ChapterNumber>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.City>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Comments>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.ConferenceName>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.CountryRegion>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Court>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Day>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.DayAccessed>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Department>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Distributor>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Edition>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.GuidString>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Institution>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.InternetSiteTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Issue>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.JournalName>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.LcId>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Medium>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Month>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.MonthAccessed>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.NumberVolumes>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Pages>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.PatentNumber>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.PeriodicalTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.ProductionCompany>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.PublicationTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Publisher>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.RecordingNumber>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.ReferenceOrder>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Reporter>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.ShortTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.StandardNumber>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.StateProvince>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Station>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Tag>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Theater>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.ThesisType>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Title>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.PatentType>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.UrlString>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Version>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Volume>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.Year>();
            builder.AddChild<DocumentFormat.OpenXml.Bibliography.YearAccessed>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.AbbreviatedCaseNumber), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.AlbumTitle), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.AuthorList), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.BookTitle), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Broadcaster), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.BroadcastTitle), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.CaseNumber), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.ChapterNumber), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.City), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Comments), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.ConferenceName), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.CountryRegion), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Court), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Day), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.DayAccessed), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Department), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Distributor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Edition), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.GuidString), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Institution), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.InternetSiteTitle), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Issue), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.JournalName), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.LcId), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Medium), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Month), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.MonthAccessed), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.NumberVolumes), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Pages), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.PatentNumber), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.PeriodicalTitle), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.ProductionCompany), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.PublicationTitle), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Publisher), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.RecordingNumber), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.ReferenceOrder), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Reporter), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.SourceType), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.ShortTitle), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.StandardNumber), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.StateProvince), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Station), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Tag), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Theater), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.ThesisType), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Title), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.PatentType), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.UrlString), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Version), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Volume), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.Year), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Bibliography.YearAccessed), 1, 1)
                }
            };
        }

        /// <summary>
        /// <para>Abbreviated Case Number.</para>
        /// <para>Represents the following element tag in the schema: b:AbbreviatedCaseNumber.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.AbbreviatedCaseNumber? AbbreviatedCaseNumber
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.AbbreviatedCaseNumber>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Album Title.</para>
        /// <para>Represents the following element tag in the schema: b:AlbumTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.AlbumTitle? AlbumTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.AlbumTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Contributors List.</para>
        /// <para>Represents the following element tag in the schema: b:Author.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.AuthorList? AuthorList
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.AuthorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Book Title.</para>
        /// <para>Represents the following element tag in the schema: b:BookTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.BookTitle? BookTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.BookTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Broadcaster.</para>
        /// <para>Represents the following element tag in the schema: b:Broadcaster.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Broadcaster? Broadcaster
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Broadcaster>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Broadcast Title.</para>
        /// <para>Represents the following element tag in the schema: b:BroadcastTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.BroadcastTitle? BroadcastTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.BroadcastTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Case Number.</para>
        /// <para>Represents the following element tag in the schema: b:CaseNumber.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.CaseNumber? CaseNumber
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.CaseNumber>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Chapter Number.</para>
        /// <para>Represents the following element tag in the schema: b:ChapterNumber.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.ChapterNumber? ChapterNumber
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.ChapterNumber>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>City.</para>
        /// <para>Represents the following element tag in the schema: b:City.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.City? City
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.City>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Comments.</para>
        /// <para>Represents the following element tag in the schema: b:Comments.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Comments? Comments
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Comments>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Conference or Proceedings Name.</para>
        /// <para>Represents the following element tag in the schema: b:ConferenceName.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.ConferenceName? ConferenceName
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.ConferenceName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Country or Region.</para>
        /// <para>Represents the following element tag in the schema: b:CountryRegion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.CountryRegion? CountryRegion
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.CountryRegion>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Court.</para>
        /// <para>Represents the following element tag in the schema: b:Court.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Court? Court
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Court>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Day.</para>
        /// <para>Represents the following element tag in the schema: b:Day.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Day? Day
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Day>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Day Accessed.</para>
        /// <para>Represents the following element tag in the schema: b:DayAccessed.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.DayAccessed? DayAccessed
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.DayAccessed>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Department.</para>
        /// <para>Represents the following element tag in the schema: b:Department.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Department? Department
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Department>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Distributor.</para>
        /// <para>Represents the following element tag in the schema: b:Distributor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Distributor? Distributor
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Distributor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Editor.</para>
        /// <para>Represents the following element tag in the schema: b:Edition.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Edition? Edition
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Edition>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>GUID.</para>
        /// <para>Represents the following element tag in the schema: b:Guid.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.GuidString? GuidString
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.GuidString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Institution.</para>
        /// <para>Represents the following element tag in the schema: b:Institution.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Institution? Institution
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Institution>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Internet Site Title.</para>
        /// <para>Represents the following element tag in the schema: b:InternetSiteTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.InternetSiteTitle? InternetSiteTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.InternetSiteTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Issue.</para>
        /// <para>Represents the following element tag in the schema: b:Issue.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Issue? Issue
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Issue>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Journal Name.</para>
        /// <para>Represents the following element tag in the schema: b:JournalName.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.JournalName? JournalName
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.JournalName>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Locale ID.</para>
        /// <para>Represents the following element tag in the schema: b:LCID.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.LcId? LcId
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.LcId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Medium.</para>
        /// <para>Represents the following element tag in the schema: b:Medium.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Medium? Medium
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Medium>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Month.</para>
        /// <para>Represents the following element tag in the schema: b:Month.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Month? Month
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Month>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Month Accessed.</para>
        /// <para>Represents the following element tag in the schema: b:MonthAccessed.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.MonthAccessed? MonthAccessed
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.MonthAccessed>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Volumes.</para>
        /// <para>Represents the following element tag in the schema: b:NumberVolumes.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.NumberVolumes? NumberVolumes
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.NumberVolumes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Pages.</para>
        /// <para>Represents the following element tag in the schema: b:Pages.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Pages? Pages
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Pages>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Patent Number.</para>
        /// <para>Represents the following element tag in the schema: b:PatentNumber.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.PatentNumber? PatentNumber
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.PatentNumber>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Periodical Title.</para>
        /// <para>Represents the following element tag in the schema: b:PeriodicalTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.PeriodicalTitle? PeriodicalTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.PeriodicalTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Production Company.</para>
        /// <para>Represents the following element tag in the schema: b:ProductionCompany.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.ProductionCompany? ProductionCompany
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.ProductionCompany>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Publication Title.</para>
        /// <para>Represents the following element tag in the schema: b:PublicationTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.PublicationTitle? PublicationTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.PublicationTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Publisher.</para>
        /// <para>Represents the following element tag in the schema: b:Publisher.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Publisher? Publisher
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Publisher>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Recording Number.</para>
        /// <para>Represents the following element tag in the schema: b:RecordingNumber.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.RecordingNumber? RecordingNumber
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.RecordingNumber>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Reference Order.</para>
        /// <para>Represents the following element tag in the schema: b:RefOrder.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.ReferenceOrder? ReferenceOrder
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.ReferenceOrder>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Reporter.</para>
        /// <para>Represents the following element tag in the schema: b:Reporter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Reporter? Reporter
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Reporter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Source Type.</para>
        /// <para>Represents the following element tag in the schema: b:SourceType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.SourceType? SourceType
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.SourceType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Short Title.</para>
        /// <para>Represents the following element tag in the schema: b:ShortTitle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.ShortTitle? ShortTitle
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.ShortTitle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Standard Number.</para>
        /// <para>Represents the following element tag in the schema: b:StandardNumber.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.StandardNumber? StandardNumber
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.StandardNumber>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>State or Province.</para>
        /// <para>Represents the following element tag in the schema: b:StateProvince.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.StateProvince? StateProvince
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.StateProvince>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Station.</para>
        /// <para>Represents the following element tag in the schema: b:Station.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Station? Station
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Station>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tag.</para>
        /// <para>Represents the following element tag in the schema: b:Tag.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Tag? Tag
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Tag>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Theater.</para>
        /// <para>Represents the following element tag in the schema: b:Theater.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Theater? Theater
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Theater>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Thesis Type.</para>
        /// <para>Represents the following element tag in the schema: b:ThesisType.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.ThesisType? ThesisType
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.ThesisType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Title.</para>
        /// <para>Represents the following element tag in the schema: b:Title.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Title? Title
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Title>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Type.</para>
        /// <para>Represents the following element tag in the schema: b:Type.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.PatentType? PatentType
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.PatentType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>URL.</para>
        /// <para>Represents the following element tag in the schema: b:URL.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.UrlString? UrlString
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.UrlString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Version.</para>
        /// <para>Represents the following element tag in the schema: b:Version.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Version? Version
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Version>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Volume.</para>
        /// <para>Represents the following element tag in the schema: b:Volume.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Volume? Volume
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Volume>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Year.</para>
        /// <para>Represents the following element tag in the schema: b:Year.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.Year? Year
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.Year>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Year Accessed.</para>
        /// <para>Represents the following element tag in the schema: b:YearAccessed.</para>
        /// </summary>
        /// <remark>
        /// xmlns:b = http://schemas.openxmlformats.org/officeDocument/2006/bibliography
        /// </remark>
        public DocumentFormat.OpenXml.Bibliography.YearAccessed? YearAccessed
        {
            get => GetElement<DocumentFormat.OpenXml.Bibliography.YearAccessed>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Source>(deep);
    }

    /// <summary>
    /// Bibliographic Data Source Types
    /// </summary>
    public enum DataSourceValues
    {
        /// <summary>
        /// Article in a Periodical.
        /// <para>When the item is serialized out as xml, its value is "ArticleInAPeriodical".</para>
        /// </summary>
        [EnumString("ArticleInAPeriodical")]
        ArticleInAPeriodical,
        /// <summary>
        /// Book.
        /// <para>When the item is serialized out as xml, its value is "Book".</para>
        /// </summary>
        [EnumString("Book")]
        Book,
        /// <summary>
        /// Book Section.
        /// <para>When the item is serialized out as xml, its value is "BookSection".</para>
        /// </summary>
        [EnumString("BookSection")]
        BookSection,
        /// <summary>
        /// Journal Article.
        /// <para>When the item is serialized out as xml, its value is "JournalArticle".</para>
        /// </summary>
        [EnumString("JournalArticle")]
        JournalArticle,
        /// <summary>
        /// Conference Proceedings.
        /// <para>When the item is serialized out as xml, its value is "ConferenceProceedings".</para>
        /// </summary>
        [EnumString("ConferenceProceedings")]
        ConferenceProceedings,
        /// <summary>
        /// Reporter.
        /// <para>When the item is serialized out as xml, its value is "Report".</para>
        /// </summary>
        [EnumString("Report")]
        Report,
        /// <summary>
        /// Sound Recording.
        /// <para>When the item is serialized out as xml, its value is "SoundRecording".</para>
        /// </summary>
        [EnumString("SoundRecording")]
        SoundRecording,
        /// <summary>
        /// Performance.
        /// <para>When the item is serialized out as xml, its value is "Performance".</para>
        /// </summary>
        [EnumString("Performance")]
        Performance,
        /// <summary>
        /// Art.
        /// <para>When the item is serialized out as xml, its value is "Art".</para>
        /// </summary>
        [EnumString("Art")]
        Art,
        /// <summary>
        /// Document from Internet Site.
        /// <para>When the item is serialized out as xml, its value is "DocumentFromInternetSite".</para>
        /// </summary>
        [EnumString("DocumentFromInternetSite")]
        DocumentFromInternetSite,
        /// <summary>
        /// Internet Site.
        /// <para>When the item is serialized out as xml, its value is "InternetSite".</para>
        /// </summary>
        [EnumString("InternetSite")]
        InternetSite,
        /// <summary>
        /// Film.
        /// <para>When the item is serialized out as xml, its value is "Film".</para>
        /// </summary>
        [EnumString("Film")]
        Film,
        /// <summary>
        /// Interview.
        /// <para>When the item is serialized out as xml, its value is "Interview".</para>
        /// </summary>
        [EnumString("Interview")]
        Interview,
        /// <summary>
        /// Patent.
        /// <para>When the item is serialized out as xml, its value is "Patent".</para>
        /// </summary>
        [EnumString("Patent")]
        Patent,
        /// <summary>
        /// Electronic Source.
        /// <para>When the item is serialized out as xml, its value is "ElectronicSource".</para>
        /// </summary>
        [EnumString("ElectronicSource")]
        ElectronicSource,
        /// <summary>
        /// Case.
        /// <para>When the item is serialized out as xml, its value is "Case".</para>
        /// </summary>
        [EnumString("Case")]
        Case,
        /// <summary>
        /// Miscellaneous.
        /// <para>When the item is serialized out as xml, its value is "Misc".</para>
        /// </summary>
        [EnumString("Misc")]
        Miscellaneous
    }
}