using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12sub_overflowIjEEbT_S1_RS1_")]
[DemangledName("bool __llvm_libc_20_1_2_::sub_overflow<unsigned int>(unsigned int, unsigned int, unsigned int&)")]
internal static partial class bool_sub_overflow_unsigned_int_unsigned_int_unsigned_int_unsigned_int
{
	public unsafe static bool Invoke(int a, int b, void* res)
	{
		Struct_ycs3bi struct_ycs3bi = llvm_usub_with_overflow_i32.Invoke(a, b);
		Struct_ycs3bi struct_ycs3bi2 = struct_ycs3bi;
		bool field_ = struct_ycs3bi2.field_1;
		Struct_ycs3bi struct_ycs3bi3 = struct_ycs3bi;
		*unchecked((int*)res) = struct_ycs3bi3.field_0;
		return field_;
	}
}
