using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sub_overflow_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12sub_overflowImEEbT_S1_RS1_")]
	[DemangledName("bool __llvm_libc_20_1_2_::sub_overflow<unsigned long>(unsigned long, unsigned long, unsigned long&)")]
	[return: NativeType("bool")]
	public unsafe static bool Invoke([MangledName("a")][NativeType("unsigned long")] long A, [MangledName("b")][NativeType("unsigned long")] long B, [MangledName("res")][NativeType("unsigned long&")] void* Res)
	{
		Struct_u6p3uf struct_u6p3uf = Llvm_usub_with_overflow_i64.Invoke(A, B);
		Struct_u6p3uf struct_u6p3uf2 = struct_u6p3uf;
		bool field_ = struct_u6p3uf2.field_1;
		Struct_u6p3uf struct_u6p3uf3 = struct_u6p3uf;
		*unchecked((long*)Res) = struct_u6p3uf3.field_0;
		return field_;
	}
}
