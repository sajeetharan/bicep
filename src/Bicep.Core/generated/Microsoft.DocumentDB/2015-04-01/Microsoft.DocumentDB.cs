// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DocumentDB_2015_04_01
    {
        private const string ProviderNamespace = "Microsoft.DocumentDB";
        private const string ApiVersion = "2015-04-01";
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_databases = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "databases"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_tables = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "tables"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_keyspaces = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "keyspaces"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_databases_settings = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "databases", "settings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_databases_containers = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "databases", "containers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_databases_collections = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "databases", "collections"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_tables_settings = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "tables", "settings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_keyspaces_settings = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "keyspaces", "settings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_keyspaces_tables = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "keyspaces", "tables"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_databases_graphs = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "databases", "graphs"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_databases_containers_settings = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "databases", "containers", "settings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_databases_collections_settings = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "databases", "collections", "settings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_keyspaces_tables_settings = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "keyspaces", "tables", "settings"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_databaseAccounts_apis_databases_graphs_settings = new ResourceTypeReference(ProviderNamespace, new[]{"databaseAccounts", "apis", "databases", "graphs", "settings"}, ApiVersion);
        private static Lazy<Microsoft_DocumentDB_2015_04_01> InstanceLazy = new Lazy<Microsoft_DocumentDB_2015_04_01>(() => new Microsoft_DocumentDB_2015_04_01());
        private Microsoft_DocumentDB_2015_04_01()
        {
            DatabaseAccountCreateUpdateProperties = new NamedObjectType("DatabaseAccountCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("consistencyPolicy", () => ConsistencyPolicy, TypePropertyFlags.None), new LazyTypeProperty("locations", () => new TypedArrayType(Location), TypePropertyFlags.Required), new TypeProperty("databaseAccountOfferType", new StringLiteralType("'Standard'"), TypePropertyFlags.Required), new TypeProperty("ipRangeFilter", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("isVirtualNetworkFilterEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableAutomaticFailover", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("capabilities", () => new TypedArrayType(Capability), TypePropertyFlags.None), new LazyTypeProperty("virtualNetworkRules", () => new TypedArrayType(VirtualNetworkRule), TypePropertyFlags.None), new TypeProperty("enableMultipleWriteLocations", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableCassandraConnector", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("connectorOffer", new StringLiteralType("'Small'"), TypePropertyFlags.None)}, null);
            ConsistencyPolicy = new NamedObjectType("ConsistencyPolicy", new ITypeProperty[]{new TypeProperty("defaultConsistencyLevel", UnionType.Create(new StringLiteralType("'Eventual'"), new StringLiteralType("'Session'"), new StringLiteralType("'BoundedStaleness'"), new StringLiteralType("'Strong'"), new StringLiteralType("'ConsistentPrefix'")), TypePropertyFlags.Required), new TypeProperty("maxStalenessPrefix", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxIntervalInSeconds", LanguageConstants.Int, TypePropertyFlags.None)}, null);
            Location = new NamedObjectType("Location", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("locationName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("documentEndpoint", LanguageConstants.String, TypePropertyFlags.ReadOnly), new TypeProperty("provisioningState", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("failoverPriority", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("isZoneRedundant", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            Capability = new NamedObjectType("Capability", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            VirtualNetworkRule = new NamedObjectType("VirtualNetworkRule", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("ignoreMissingVNetServiceEndpoint", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            SqlDatabaseCreateUpdateProperties = new NamedObjectType("SqlDatabaseCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => SqlDatabaseResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            SqlDatabaseResource = new NamedObjectType("SqlDatabaseResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            ThroughputUpdateProperties = new NamedObjectType("ThroughputUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => ThroughputResource, TypePropertyFlags.Required)}, null);
            ThroughputResource = new NamedObjectType("ThroughputResource", new ITypeProperty[]{new TypeProperty("throughput", LanguageConstants.Int, TypePropertyFlags.Required)}, null);
            SqlContainerCreateUpdateProperties = new NamedObjectType("SqlContainerCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => SqlContainerResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            SqlContainerResource = new NamedObjectType("SqlContainerResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("indexingPolicy", () => IndexingPolicy, TypePropertyFlags.None), new LazyTypeProperty("partitionKey", () => ContainerPartitionKey, TypePropertyFlags.None), new TypeProperty("defaultTtl", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("uniqueKeyPolicy", () => UniqueKeyPolicy, TypePropertyFlags.None), new LazyTypeProperty("conflictResolutionPolicy", () => ConflictResolutionPolicy, TypePropertyFlags.None)}, null);
            IndexingPolicy = new NamedObjectType("IndexingPolicy", new ITypeProperty[]{new TypeProperty("automatic", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("indexingMode", UnionType.Create(new StringLiteralType("'Consistent'"), new StringLiteralType("'Lazy'"), new StringLiteralType("'None'")), TypePropertyFlags.None), new LazyTypeProperty("includedPaths", () => new TypedArrayType(IncludedPath), TypePropertyFlags.None), new LazyTypeProperty("excludedPaths", () => new TypedArrayType(ExcludedPath), TypePropertyFlags.None)}, null);
            IncludedPath = new NamedObjectType("IncludedPath", new ITypeProperty[]{new TypeProperty("path", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("indexes", () => new TypedArrayType(Indexes), TypePropertyFlags.None)}, null);
            Indexes = new NamedObjectType("Indexes", new ITypeProperty[]{new TypeProperty("dataType", UnionType.Create(new StringLiteralType("'String'"), new StringLiteralType("'Number'"), new StringLiteralType("'Point'"), new StringLiteralType("'Polygon'"), new StringLiteralType("'LineString'"), new StringLiteralType("'MultiPolygon'")), TypePropertyFlags.None), new TypeProperty("precision", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("kind", UnionType.Create(new StringLiteralType("'Hash'"), new StringLiteralType("'Range'"), new StringLiteralType("'Spatial'")), TypePropertyFlags.None)}, null);
            ExcludedPath = new NamedObjectType("ExcludedPath", new ITypeProperty[]{new TypeProperty("path", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ContainerPartitionKey = new NamedObjectType("ContainerPartitionKey", new ITypeProperty[]{new TypeProperty("paths", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None), new TypeProperty("kind", UnionType.Create(new StringLiteralType("'Hash'"), new StringLiteralType("'Range'")), TypePropertyFlags.None)}, null);
            UniqueKeyPolicy = new NamedObjectType("UniqueKeyPolicy", new ITypeProperty[]{new LazyTypeProperty("uniqueKeys", () => new TypedArrayType(UniqueKey), TypePropertyFlags.None)}, null);
            UniqueKey = new NamedObjectType("UniqueKey", new ITypeProperty[]{new TypeProperty("paths", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            ConflictResolutionPolicy = new NamedObjectType("ConflictResolutionPolicy", new ITypeProperty[]{new TypeProperty("mode", UnionType.Create(new StringLiteralType("'LastWriterWins'"), new StringLiteralType("'Custom'")), TypePropertyFlags.None), new TypeProperty("conflictResolutionPath", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("conflictResolutionProcedure", LanguageConstants.String, TypePropertyFlags.None)}, null);
            MongoDBDatabaseCreateUpdateProperties = new NamedObjectType("MongoDBDatabaseCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => MongoDBDatabaseResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            MongoDBDatabaseResource = new NamedObjectType("MongoDBDatabaseResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            MongoDBCollectionCreateUpdateProperties = new NamedObjectType("MongoDBCollectionCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => MongoDBCollectionResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            MongoDBCollectionResource = new NamedObjectType("MongoDBCollectionResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("shardKey", new NamedObjectType("shardKey", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new LazyTypeProperty("indexes", () => new TypedArrayType(MongoIndex), TypePropertyFlags.None)}, null);
            MongoIndex = new NamedObjectType("MongoIndex", new ITypeProperty[]{new LazyTypeProperty("key", () => MongoIndexKeys, TypePropertyFlags.None), new LazyTypeProperty("options", () => MongoIndexOptions, TypePropertyFlags.None)}, null);
            MongoIndexKeys = new NamedObjectType("MongoIndexKeys", new ITypeProperty[]{new TypeProperty("keys", new TypedArrayType(LanguageConstants.String), TypePropertyFlags.None)}, null);
            MongoIndexOptions = new NamedObjectType("MongoIndexOptions", new ITypeProperty[]{new TypeProperty("expireAfterSeconds", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("unique", LanguageConstants.Bool, TypePropertyFlags.None)}, null);
            TableCreateUpdateProperties = new NamedObjectType("TableCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => TableResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            TableResource = new NamedObjectType("TableResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            CassandraKeyspaceCreateUpdateProperties = new NamedObjectType("CassandraKeyspaceCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => CassandraKeyspaceResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            CassandraKeyspaceResource = new NamedObjectType("CassandraKeyspaceResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            CassandraTableCreateUpdateProperties = new NamedObjectType("CassandraTableCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => CassandraTableResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            CassandraTableResource = new NamedObjectType("CassandraTableResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("defaultTtl", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("schema", () => CassandraSchema, TypePropertyFlags.None)}, null);
            CassandraSchema = new NamedObjectType("CassandraSchema", new ITypeProperty[]{new LazyTypeProperty("columns", () => new TypedArrayType(Column), TypePropertyFlags.None), new LazyTypeProperty("partitionKeys", () => new TypedArrayType(CassandraPartitionKey), TypePropertyFlags.None), new LazyTypeProperty("clusterKeys", () => new TypedArrayType(ClusterKey), TypePropertyFlags.None)}, null);
            Column = new NamedObjectType("Column", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.None)}, null);
            CassandraPartitionKey = new NamedObjectType("CassandraPartitionKey", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None)}, null);
            ClusterKey = new NamedObjectType("ClusterKey", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("orderBy", LanguageConstants.String, TypePropertyFlags.None)}, null);
            GremlinDatabaseCreateUpdateProperties = new NamedObjectType("GremlinDatabaseCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => GremlinDatabaseResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            GremlinDatabaseResource = new NamedObjectType("GremlinDatabaseResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required)}, null);
            GremlinGraphCreateUpdateProperties = new NamedObjectType("GremlinGraphCreateUpdateProperties", new ITypeProperty[]{new LazyTypeProperty("resource", () => GremlinGraphResource, TypePropertyFlags.Required), new TypeProperty("options", new NamedObjectType("options", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.Required)}, null);
            GremlinGraphResource = new NamedObjectType("GremlinGraphResource", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("indexingPolicy", () => IndexingPolicy, TypePropertyFlags.None), new LazyTypeProperty("partitionKey", () => ContainerPartitionKey, TypePropertyFlags.None), new TypeProperty("defaultTtl", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("uniqueKeyPolicy", () => UniqueKeyPolicy, TypePropertyFlags.None), new LazyTypeProperty("conflictResolutionPolicy", () => ConflictResolutionPolicy, TypePropertyFlags.None)}, null);
            ResourceType_databaseAccounts = new ResourceType("Microsoft.DocumentDB/databaseAccounts", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", new NamedObjectType("tags", new ITypeProperty[]{}, new TypeProperty("additionalProperties", LanguageConstants.String, TypePropertyFlags.None)), TypePropertyFlags.None), new TypeProperty("kind", UnionType.Create(new StringLiteralType("'GlobalDocumentDB'"), new StringLiteralType("'MongoDB'"), new StringLiteralType("'Parse'")), TypePropertyFlags.None), new LazyTypeProperty("properties", () => DatabaseAccountCreateUpdateProperties, TypePropertyFlags.Required), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts);
            ResourceType_databaseAccounts_apis_databases = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/databases", new ITypeProperty[]{new LazyTypeProperty("properties", () => SqlDatabaseCreateUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/databases'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_databases);
            ResourceType_databaseAccounts_apis_tables = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/tables", new ITypeProperty[]{new LazyTypeProperty("properties", () => TableCreateUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/tables'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_tables);
            ResourceType_databaseAccounts_apis_keyspaces = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/keyspaces", new ITypeProperty[]{new LazyTypeProperty("properties", () => CassandraKeyspaceCreateUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/keyspaces'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_keyspaces);
            ResourceType_databaseAccounts_apis_databases_settings = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/databases/settings", new ITypeProperty[]{new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/databases/settings'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_databases_settings);
            ResourceType_databaseAccounts_apis_databases_containers = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/databases/containers", new ITypeProperty[]{new LazyTypeProperty("properties", () => SqlContainerCreateUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/databases/containers'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_databases_containers);
            ResourceType_databaseAccounts_apis_databases_collections = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/databases/collections", new ITypeProperty[]{new LazyTypeProperty("properties", () => MongoDBCollectionCreateUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/databases/collections'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_databases_collections);
            ResourceType_databaseAccounts_apis_tables_settings = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/tables/settings", new ITypeProperty[]{new LazyTypeProperty("properties", () => ThroughputUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/tables/settings'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_tables_settings);
            ResourceType_databaseAccounts_apis_keyspaces_settings = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/keyspaces/settings", new ITypeProperty[]{new LazyTypeProperty("properties", () => ThroughputUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/keyspaces/settings'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_keyspaces_settings);
            ResourceType_databaseAccounts_apis_keyspaces_tables = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/keyspaces/tables", new ITypeProperty[]{new LazyTypeProperty("properties", () => CassandraTableCreateUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/keyspaces/tables'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_keyspaces_tables);
            ResourceType_databaseAccounts_apis_databases_graphs = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/databases/graphs", new ITypeProperty[]{new LazyTypeProperty("properties", () => GremlinGraphCreateUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/databases/graphs'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_databases_graphs);
            ResourceType_databaseAccounts_apis_databases_containers_settings = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/databases/containers/settings", new ITypeProperty[]{new LazyTypeProperty("properties", () => ThroughputUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/databases/containers/settings'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_databases_containers_settings);
            ResourceType_databaseAccounts_apis_databases_collections_settings = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/databases/collections/settings", new ITypeProperty[]{new LazyTypeProperty("properties", () => ThroughputUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/databases/collections/settings'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_databases_collections_settings);
            ResourceType_databaseAccounts_apis_keyspaces_tables_settings = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/keyspaces/tables/settings", new ITypeProperty[]{new LazyTypeProperty("properties", () => ThroughputUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/keyspaces/tables/settings'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_keyspaces_tables_settings);
            ResourceType_databaseAccounts_apis_databases_graphs_settings = new ResourceType("Microsoft.DocumentDB/databaseAccounts/apis/databases/graphs/settings", new ITypeProperty[]{new LazyTypeProperty("properties", () => ThroughputUpdateProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", new StringLiteralType("'Microsoft.DocumentDB/databaseAccounts/apis/databases/graphs/settings'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", new StringLiteralType("'2015-04-01'"), TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("dependsOn", new TypedArrayType(LanguageConstants.ResourceRef), TypePropertyFlags.WriteOnly)}, null, ResourceTypeReference_databaseAccounts_apis_databases_graphs_settings);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_databaseAccounts, () => InstanceLazy.Value.ResourceType_databaseAccounts);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_databases, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_databases);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_tables, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_tables);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_keyspaces, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_keyspaces);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_databases_settings, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_databases_settings);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_databases_containers, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_databases_containers);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_databases_collections, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_databases_collections);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_tables_settings, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_tables_settings);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_keyspaces_settings, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_keyspaces_settings);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_keyspaces_tables, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_keyspaces_tables);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_databases_graphs, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_databases_graphs);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_databases_containers_settings, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_databases_containers_settings);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_databases_collections_settings, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_databases_collections_settings);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_keyspaces_tables_settings, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_keyspaces_tables_settings);
            registrar.RegisterType(ResourceTypeReference_databaseAccounts_apis_databases_graphs_settings, () => InstanceLazy.Value.ResourceType_databaseAccounts_apis_databases_graphs_settings);
        }
        private readonly ResourceType ResourceType_databaseAccounts;
        private readonly ResourceType ResourceType_databaseAccounts_apis_databases;
        private readonly ResourceType ResourceType_databaseAccounts_apis_tables;
        private readonly ResourceType ResourceType_databaseAccounts_apis_keyspaces;
        private readonly ResourceType ResourceType_databaseAccounts_apis_databases_settings;
        private readonly ResourceType ResourceType_databaseAccounts_apis_databases_containers;
        private readonly ResourceType ResourceType_databaseAccounts_apis_databases_collections;
        private readonly ResourceType ResourceType_databaseAccounts_apis_tables_settings;
        private readonly ResourceType ResourceType_databaseAccounts_apis_keyspaces_settings;
        private readonly ResourceType ResourceType_databaseAccounts_apis_keyspaces_tables;
        private readonly ResourceType ResourceType_databaseAccounts_apis_databases_graphs;
        private readonly ResourceType ResourceType_databaseAccounts_apis_databases_containers_settings;
        private readonly ResourceType ResourceType_databaseAccounts_apis_databases_collections_settings;
        private readonly ResourceType ResourceType_databaseAccounts_apis_keyspaces_tables_settings;
        private readonly ResourceType ResourceType_databaseAccounts_apis_databases_graphs_settings;
        private readonly TypeSymbol DatabaseAccountCreateUpdateProperties;
        private readonly TypeSymbol ConsistencyPolicy;
        private readonly TypeSymbol Location;
        private readonly TypeSymbol Capability;
        private readonly TypeSymbol VirtualNetworkRule;
        private readonly TypeSymbol SqlDatabaseCreateUpdateProperties;
        private readonly TypeSymbol SqlDatabaseResource;
        private readonly TypeSymbol ThroughputUpdateProperties;
        private readonly TypeSymbol ThroughputResource;
        private readonly TypeSymbol SqlContainerCreateUpdateProperties;
        private readonly TypeSymbol SqlContainerResource;
        private readonly TypeSymbol IndexingPolicy;
        private readonly TypeSymbol IncludedPath;
        private readonly TypeSymbol Indexes;
        private readonly TypeSymbol ExcludedPath;
        private readonly TypeSymbol ContainerPartitionKey;
        private readonly TypeSymbol UniqueKeyPolicy;
        private readonly TypeSymbol UniqueKey;
        private readonly TypeSymbol ConflictResolutionPolicy;
        private readonly TypeSymbol MongoDBDatabaseCreateUpdateProperties;
        private readonly TypeSymbol MongoDBDatabaseResource;
        private readonly TypeSymbol MongoDBCollectionCreateUpdateProperties;
        private readonly TypeSymbol MongoDBCollectionResource;
        private readonly TypeSymbol MongoIndex;
        private readonly TypeSymbol MongoIndexKeys;
        private readonly TypeSymbol MongoIndexOptions;
        private readonly TypeSymbol TableCreateUpdateProperties;
        private readonly TypeSymbol TableResource;
        private readonly TypeSymbol CassandraKeyspaceCreateUpdateProperties;
        private readonly TypeSymbol CassandraKeyspaceResource;
        private readonly TypeSymbol CassandraTableCreateUpdateProperties;
        private readonly TypeSymbol CassandraTableResource;
        private readonly TypeSymbol CassandraSchema;
        private readonly TypeSymbol Column;
        private readonly TypeSymbol CassandraPartitionKey;
        private readonly TypeSymbol ClusterKey;
        private readonly TypeSymbol GremlinDatabaseCreateUpdateProperties;
        private readonly TypeSymbol GremlinDatabaseResource;
        private readonly TypeSymbol GremlinGraphCreateUpdateProperties;
        private readonly TypeSymbol GremlinGraphResource;
    }
}