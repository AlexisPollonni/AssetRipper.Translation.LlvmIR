using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sub_overflow_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12sub_overflowImEEbT_S1_RS1_")]
	[DemangledName("bool __llvm_libc_20_1_2_::sub_overflow<unsigned long>(unsigned long, unsigned long, unsigned long&)")]
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("unsigned long")] long a, [NativeType("unsigned long")] long b, [NativeType("unsigned long&")] void* res)
	{
		Struct_u6p3uf struct_u6p3uf = llvm_usub_with_overflow_i64.Invoke(a, b);
		Struct_u6p3uf struct_u6p3uf2 = struct_u6p3uf;
		bool field_ = struct_u6p3uf2.field_1;
		Struct_u6p3uf struct_u6p3uf3 = struct_u6p3uf;
		*unchecked((long*)res) = struct_u6p3uf3.field_0;
		return field_;
	}
}
