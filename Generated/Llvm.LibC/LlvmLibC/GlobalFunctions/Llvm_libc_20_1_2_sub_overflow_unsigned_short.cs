using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_sub_overflow_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12sub_overflowItEEbT_S1_RS1_")]
	[DemangledName("bool __llvm_libc_20_1_2_::sub_overflow<unsigned short>(unsigned short, unsigned short, unsigned short&)")]
	[return: NativeType("bool")]
	public unsafe static bool Invoke([MangledName("a")][NativeType("unsigned short")] short A, [MangledName("b")][NativeType("unsigned short")] short B, [MangledName("res")][NativeType("unsigned short&")] void* Res)
	{
		Struct_yzqsj9 struct_yzqsj = Llvm_usub_with_overflow_i16.Invoke(A, B);
		Struct_yzqsj9 struct_yzqsj2 = struct_yzqsj;
		bool field_ = struct_yzqsj2.field_1;
		Struct_yzqsj9 struct_yzqsj3 = struct_yzqsj;
		*unchecked((short*)Res) = struct_yzqsj3.field_0;
		return field_;
	}
}
