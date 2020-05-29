﻿using System;
using System.Diagnostics;

namespace ProtoBuf.Internal.Serializers
{
    internal sealed class GuidSerializer : IRuntimeProtoSerializerNode
    {
        internal static GuidSerializer Create(CompatibilityLevel _)
            => s_Instance; // TODO: implement string

        private static readonly GuidSerializer s_Instance = new GuidSerializer();

        private GuidSerializer() { }

        private static readonly Type expectedType = typeof(Guid);

        public Type ExpectedType { get { return expectedType; } }

        bool IRuntimeProtoSerializerNode.RequiresOldValue => false;

        bool IRuntimeProtoSerializerNode.ReturnsValue => true;

        public void Write(ref ProtoWriter.State state, object value)
        {
            BclHelpers.WriteGuid(ref state, (Guid)value);
        }

        public object Read(ref ProtoReader.State state, object value)
        {
            Debug.Assert(value == null); // since replaces
            return BclHelpers.ReadGuid(ref state);
        }

        void IRuntimeProtoSerializerNode.EmitWrite(Compiler.CompilerContext ctx, Compiler.Local valueFrom)
        {
            ctx.EmitStateBasedWrite(nameof(BclHelpers.WriteGuid), valueFrom, typeof(BclHelpers));
        }

        void IRuntimeProtoSerializerNode.EmitRead(Compiler.CompilerContext ctx, Compiler.Local entity)
        {
            ctx.EmitStateBasedRead(typeof(BclHelpers), nameof(BclHelpers.ReadGuid), ExpectedType);
        }
    }
}