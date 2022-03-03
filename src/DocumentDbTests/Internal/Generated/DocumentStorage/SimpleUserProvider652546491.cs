// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Reading.Linq;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertSimpleUserOperation652546491
    public class UpsertSimpleUserOperation652546491 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>
    {
        private readonly DocumentDbTests.Reading.Linq.SimpleUser _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertSimpleUserOperation652546491(DocumentDbTests.Reading.Linq.SimpleUser document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_simpleuser(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertSimpleUserOperation652546491
    
    
    // START: InsertSimpleUserOperation652546491
    public class InsertSimpleUserOperation652546491 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>
    {
        private readonly DocumentDbTests.Reading.Linq.SimpleUser _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertSimpleUserOperation652546491(DocumentDbTests.Reading.Linq.SimpleUser document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_simpleuser(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertSimpleUserOperation652546491
    
    
    // START: UpdateSimpleUserOperation652546491
    public class UpdateSimpleUserOperation652546491 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>
    {
        private readonly DocumentDbTests.Reading.Linq.SimpleUser _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateSimpleUserOperation652546491(DocumentDbTests.Reading.Linq.SimpleUser document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_simpleuser(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateSimpleUserOperation652546491
    
    
    // START: QueryOnlySimpleUserSelector652546491
    public class QueryOnlySimpleUserSelector652546491 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<DocumentDbTests.Reading.Linq.SimpleUser>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlySimpleUserSelector652546491(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Reading.Linq.SimpleUser Resolve(System.Data.Common.DbDataReader reader)
        {

            DocumentDbTests.Reading.Linq.SimpleUser document;
            document = _serializer.FromJson<DocumentDbTests.Reading.Linq.SimpleUser>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Reading.Linq.SimpleUser> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            DocumentDbTests.Reading.Linq.SimpleUser document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Reading.Linq.SimpleUser>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlySimpleUserSelector652546491
    
    
    // START: LightweightSimpleUserSelector652546491
    public class LightweightSimpleUserSelector652546491 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Reading.Linq.SimpleUser>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightSimpleUserSelector652546491(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Reading.Linq.SimpleUser Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            DocumentDbTests.Reading.Linq.SimpleUser document;
            document = _serializer.FromJson<DocumentDbTests.Reading.Linq.SimpleUser>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Reading.Linq.SimpleUser> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            DocumentDbTests.Reading.Linq.SimpleUser document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Reading.Linq.SimpleUser>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightSimpleUserSelector652546491
    
    
    // START: IdentityMapSimpleUserSelector652546491
    public class IdentityMapSimpleUserSelector652546491 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Reading.Linq.SimpleUser>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapSimpleUserSelector652546491(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Reading.Linq.SimpleUser Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Reading.Linq.SimpleUser document;
            document = _serializer.FromJson<DocumentDbTests.Reading.Linq.SimpleUser>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Reading.Linq.SimpleUser> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Reading.Linq.SimpleUser document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Reading.Linq.SimpleUser>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapSimpleUserSelector652546491
    
    
    // START: DirtyTrackingSimpleUserSelector652546491
    public class DirtyTrackingSimpleUserSelector652546491 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Reading.Linq.SimpleUser>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingSimpleUserSelector652546491(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Reading.Linq.SimpleUser Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Reading.Linq.SimpleUser document;
            document = _serializer.FromJson<DocumentDbTests.Reading.Linq.SimpleUser>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Reading.Linq.SimpleUser> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Reading.Linq.SimpleUser document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Reading.Linq.SimpleUser>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingSimpleUserSelector652546491
    
    
    // START: QueryOnlySimpleUserDocumentStorage652546491
    public class QueryOnlySimpleUserDocumentStorage652546491 : Marten.Internal.Storage.QueryOnlyDocumentStorage<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlySimpleUserDocumentStorage652546491(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Reading.Linq.SimpleUser document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Reading.Linq.SimpleUser document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlySimpleUserSelector652546491(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlySimpleUserDocumentStorage652546491
    
    
    // START: LightweightSimpleUserDocumentStorage652546491
    public class LightweightSimpleUserDocumentStorage652546491 : Marten.Internal.Storage.LightweightDocumentStorage<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightSimpleUserDocumentStorage652546491(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Reading.Linq.SimpleUser document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Reading.Linq.SimpleUser document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightSimpleUserSelector652546491(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightSimpleUserDocumentStorage652546491
    
    
    // START: IdentityMapSimpleUserDocumentStorage652546491
    public class IdentityMapSimpleUserDocumentStorage652546491 : Marten.Internal.Storage.IdentityMapDocumentStorage<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapSimpleUserDocumentStorage652546491(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Reading.Linq.SimpleUser document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Reading.Linq.SimpleUser document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapSimpleUserSelector652546491(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapSimpleUserDocumentStorage652546491
    
    
    // START: DirtyTrackingSimpleUserDocumentStorage652546491
    public class DirtyTrackingSimpleUserDocumentStorage652546491 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingSimpleUserDocumentStorage652546491(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Reading.Linq.SimpleUser document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertSimpleUserOperation652546491
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Reading.Linq.SimpleUser document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingSimpleUserSelector652546491(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingSimpleUserDocumentStorage652546491
    
    
    // START: SimpleUserBulkLoader652546491
    public class SimpleUserBulkLoader652546491 : Marten.Internal.CodeGeneration.BulkLoader<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid> _storage;

        public SimpleUserBulkLoader652546491(Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Reading.Linq.SimpleUser, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_simpleuser(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_simpleuser_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_simpleuser (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_simpleuser_temp.\"id\", mt_doc_simpleuser_temp.\"data\", mt_doc_simpleuser_temp.\"mt_version\", mt_doc_simpleuser_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_simpleuser_temp left join public.mt_doc_simpleuser on mt_doc_simpleuser_temp.id = public.mt_doc_simpleuser.id where public.mt_doc_simpleuser.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_simpleuser target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_simpleuser_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_simpleuser_temp as select * from public.mt_doc_simpleuser limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Reading.Linq.SimpleUser document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: SimpleUserBulkLoader652546491
    
    
    // START: SimpleUserProvider652546491
    public class SimpleUserProvider652546491 : Marten.Internal.Storage.DocumentProvider<DocumentDbTests.Reading.Linq.SimpleUser>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public SimpleUserProvider652546491(Marten.Schema.DocumentMapping mapping) : base(new SimpleUserBulkLoader652546491(new QueryOnlySimpleUserDocumentStorage652546491(mapping)), new QueryOnlySimpleUserDocumentStorage652546491(mapping), new LightweightSimpleUserDocumentStorage652546491(mapping), new IdentityMapSimpleUserDocumentStorage652546491(mapping), new DirtyTrackingSimpleUserDocumentStorage652546491(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: SimpleUserProvider652546491
    
    
}
