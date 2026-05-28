using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sub_overflow_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12sub_overflowIjEEbT_S1_RS1_")]
	[DemangledName("bool __llvm_libc_20_1_2_::sub_overflow<unsigned int>(unsigned int, unsigned int, unsigned int&)")]
	[return: NativeType("bool")]
	public unsafe static bool Invoke([MangledName("a")][NativeType("unsigned int")] int A, [MangledName("b")][NativeType("unsigned int")] int B, [MangledName("res")][NativeType("unsigned int&")] void* Res)
	{
		Struct_ycs3bi struct_ycs3bi = Llvm_usub_with_overflow_i32.Invoke(A, B);
		Struct_ycs3bi struct_ycs3bi2 = struct_ycs3bi;
		bool field_ = struct_ycs3bi2.field_1;
		Struct_ycs3bi struct_ycs3bi3 = struct_ycs3bi;
		*unchecked((int*)Res) = struct_ycs3bi3.field_0;
		return field_;
	}
}
