<Query Kind="Statements">
  <NuGetReference>Microsoft.AspNetCore.App.Ref</NuGetReference>
  <NuGetReference>XmlSchemaClassGenerator-beta</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Text.Json</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>XmlSchemaClassGenerator</Namespace>
  <IncludeAspNet>true</IncludeAspNet>
</Query>

var queryFile = new FileInfo(Util.CurrentQueryPath);
var rootDirectory = queryFile.Directory;
var sourceDirectory = rootDirectory!.CreateSubdirectory("xsd")!.CreateSubdirectory("maindoc");
var fileLog = new List<string>();
var outputDirectory = new DirectoryInfo(Path.Combine(rootDirectory.FullName, "Frank.Finance.Documents.Ubl"));
var generator = UblGenerator.CreateGenerator(outputDirectory, "Frank.Finance.Documents.Ubl", fileLog);

generator.Generate(sourceDirectory.EnumerateFiles().Select(x => x.FullName).ToList().Dump());

fileLog.Dump();

public static class UblGenerator
{
	public static Generator CreateGenerator(DirectoryInfo outputDirectory, string rootNamespace, List<string> fileLog)
	{
		return new Generator
		{
			OutputFolder = outputDirectory.FullName,
			Log = s => fileLog.Add(s),
			PrivateMemberPrefix = "_",
			IntegerDataType = typeof(int),
			CollectionImplementationType = typeof(List<>),
			CollectionType = typeof(List<>),
			NamingScheme = NamingScheme.PascalCase,
			DataAnnotationMode = DataAnnotationMode.None,
			CollectionSettersMode = CollectionSettersMode.PublicWithoutConstructorInitialization,
			CodeTypeReferenceOptions = System.CodeDom.CodeTypeReferenceOptions.GenericTypeParameter,
			NamespaceProvider = new NamespaceProvider()
			{
				GenerateNamespace = x =>
				{
					var namespaceBuilder = new StringBuilder();

					namespaceBuilder.Append(rootNamespace);
					namespaceBuilder.Append(".");

					var customNamespace = new Regex("[^a-zA-Z0-9]").Replace(x.XmlSchemaNamespace, "_");

					if (customNamespace.StartsWith("urn_oasis_names_specification_ubl_schema_xsd_"))
					{
						var documentName = customNamespace
							.Replace("urn_oasis_names_specification_ubl_schema_xsd_", "")
							.Replace("_2", "");
						namespaceBuilder.Append(documentName);
					}
					if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonExtensionComponents_2")
					{
						namespaceBuilder.Append("CommonExtensionComponents");
					}
					if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonSignatureComponents_2")
					{
						namespaceBuilder.Append("CommonSignatureComponents");
					}
					if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_SignatureBasicComponents_2")
					{
						namespaceBuilder.Append("SignatureBasicComponents");
					}
					if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_SignatureAggregateComponents_2")
					{
						namespaceBuilder.Append("SignatureAggregateComponents");
					}
					if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonAggregateComponents_2")
					{
						namespaceBuilder.Append("CommonAggregateComponents");
					}
					if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_CommonBasicComponents_2")
					{
						namespaceBuilder.Append("CommonBasicComponents");
					}
					if (customNamespace == "urn_oasis_names_specification_ubl_schema_xsd_UnqualifiedDataTypes_2")
					{
						namespaceBuilder.Append("UnqualifiedDataTypes");
					}
					if (customNamespace == "urn_un_unece_uncefact_data_specification_CoreComponentTypeSchemaModule_2")
					{
						namespaceBuilder.Append("CoreComponentTypes");
					}
					if (customNamespace.StartsWith("http___"))
					{
						namespaceBuilder.Append("CoreComponentTypes");
					}

					return namespaceBuilder.ToString().Dump();
				}
			},
			GenerateInterfaces = true,
			NetCoreSpecificCode = true,
			SeparateClasses = true,
			EntityFramework = false,
			EnumAsString = true,
			MapUnionToWidestCommonType = true,
			GenerateNullables = true,
			DoNotForceIsNullable = false,
			EmitOrder = false,
			SeparateNamespaceHierarchy = false,
			DisableComments = false,
			GenerateDescriptionAttribute = false,
			EnableNullableReferenceAttributes = false,
			CompactTypeNames = true,
			SeparateSubstitutes = true,
			GenerateSerializableAttribute = false,
			CreateGeneratedCodeAttributeVersion = false,
			AssemblyVisible = false,
			EnableUpaCheck = true,
			UseShouldSerializePattern = false,
			GenerateDesignerCategoryAttribute = false
		};
	}
}