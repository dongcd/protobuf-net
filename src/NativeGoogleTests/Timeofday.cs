// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/type/timeofday.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Type {

  /// <summary>Holder for reflection information generated from google/type/timeofday.proto</summary>
  public static partial class TimeofdayReflection {

    #region Descriptor
    /// <summary>File descriptor for google/type/timeofday.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TimeofdayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtnb29nbGUvdHlwZS90aW1lb2ZkYXkucHJvdG8SC2dvb2dsZS50eXBlIksK",
            "CVRpbWVPZkRheRINCgVob3VycxgBIAEoBRIPCgdtaW51dGVzGAIgASgFEg8K",
            "B3NlY29uZHMYAyABKAUSDQoFbmFub3MYBCABKAVCbAoPY29tLmdvb2dsZS50",
            "eXBlQg5UaW1lT2ZEYXlQcm90b1ABWj5nb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL3R5cGUvdGltZW9mZGF5O3RpbWVvZmRhefgBAaIC",
            "A0dUUGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Type.TimeOfDay), global::Google.Type.TimeOfDay.Parser, new[]{ "Hours", "Minutes", "Seconds", "Nanos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a time of day. The date and time zone are either not significant
  /// or are specified elsewhere. An API may choose to allow leap seconds. Related
  /// types are [google.type.Date][google.type.Date] and `google.protobuf.Timestamp`.
  /// </summary>
  public sealed partial class TimeOfDay : pb::IMessage<TimeOfDay>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TimeOfDay> _parser = new pb::MessageParser<TimeOfDay>(() => new TimeOfDay());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeOfDay> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Type.TimeofdayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeOfDay() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeOfDay(TimeOfDay other) : this() {
      hours_ = other.hours_;
      minutes_ = other.minutes_;
      seconds_ = other.seconds_;
      nanos_ = other.nanos_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeOfDay Clone() {
      return new TimeOfDay(this);
    }

    /// <summary>Field number for the "hours" field.</summary>
    public const int HoursFieldNumber = 1;
    private int hours_;
    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose
    /// to allow the value "24:00:00" for scenarios like business closing time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Hours {
      get { return hours_; }
      set {
        hours_ = value;
      }
    }

    /// <summary>Field number for the "minutes" field.</summary>
    public const int MinutesFieldNumber = 2;
    private int minutes_;
    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Minutes {
      get { return minutes_; }
      set {
        minutes_ = value;
      }
    }

    /// <summary>Field number for the "seconds" field.</summary>
    public const int SecondsFieldNumber = 3;
    private int seconds_;
    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may
    /// allow the value 60 if it allows leap-seconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Seconds {
      get { return seconds_; }
      set {
        seconds_ = value;
      }
    }

    /// <summary>Field number for the "nanos" field.</summary>
    public const int NanosFieldNumber = 4;
    private int nanos_;
    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Nanos {
      get { return nanos_; }
      set {
        nanos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeOfDay);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeOfDay other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hours != other.Hours) return false;
      if (Minutes != other.Minutes) return false;
      if (Seconds != other.Seconds) return false;
      if (Nanos != other.Nanos) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Hours != 0) hash ^= Hours.GetHashCode();
      if (Minutes != 0) hash ^= Minutes.GetHashCode();
      if (Seconds != 0) hash ^= Seconds.GetHashCode();
      if (Nanos != 0) hash ^= Nanos.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Hours != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Hours);
      }
      if (Minutes != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Minutes);
      }
      if (Seconds != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Seconds);
      }
      if (Nanos != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Nanos);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Hours != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Hours);
      }
      if (Minutes != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Minutes);
      }
      if (Seconds != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Seconds);
      }
      if (Nanos != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Nanos);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Hours != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hours);
      }
      if (Minutes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Minutes);
      }
      if (Seconds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Seconds);
      }
      if (Nanos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Nanos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeOfDay other) {
      if (other == null) {
        return;
      }
      if (other.Hours != 0) {
        Hours = other.Hours;
      }
      if (other.Minutes != 0) {
        Minutes = other.Minutes;
      }
      if (other.Seconds != 0) {
        Seconds = other.Seconds;
      }
      if (other.Nanos != 0) {
        Nanos = other.Nanos;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Hours = input.ReadInt32();
            break;
          }
          case 16: {
            Minutes = input.ReadInt32();
            break;
          }
          case 24: {
            Seconds = input.ReadInt32();
            break;
          }
          case 32: {
            Nanos = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Hours = input.ReadInt32();
            break;
          }
          case 16: {
            Minutes = input.ReadInt32();
            break;
          }
          case 24: {
            Seconds = input.ReadInt32();
            break;
          }
          case 32: {
            Nanos = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
