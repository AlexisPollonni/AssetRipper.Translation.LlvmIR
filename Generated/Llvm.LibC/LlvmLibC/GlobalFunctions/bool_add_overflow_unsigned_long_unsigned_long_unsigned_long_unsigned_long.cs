using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12add_overflowImEEbT_S1_RS1_")]
[DemangledName("bool __llvm_libc_20_1_2_::add_overflow<unsigned long>(unsigned long, unsigned long, unsigned long&)")]
internal static partial class bool_add_overflow_unsigned_long_unsigned_long_unsigned_long_unsigned_long
{
	public unsafe static bool Invoke(long a, long b, void* res)
	{
		Struct_u6p3uf struct_u6p3uf = llvm_uadd_with_overflow_i64.Invoke(a, b);
		Struct_u6p3uf struct_u6p3uf2 = struct_u6p3uf;
		bool field_ = struct_u6p3uf2.field_1;
		Struct_u6p3uf struct_u6p3uf3 = struct_u6p3uf;
		*unchecked((long*)res) = struct_u6p3uf3.field_0;
		return field_;
	}
}
