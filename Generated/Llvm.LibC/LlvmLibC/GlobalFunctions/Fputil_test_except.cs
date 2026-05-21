using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_test_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11test_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::test_except(int)")]
	public unsafe static int Invoke([MangledName("excepts")][NativeType("int")] int Excepts)
	{
		short num = 0;
		int num2 = 0;
		short num3 = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = Internal_get_x87_status_word.Invoke();
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = Internal_get_mxcsr.Invoke();
		Llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = Internal_get_status_value_for_except.Invoke(Excepts);
		int result = Internal_exception_status_to_macro.Invoke(unchecked((short)((ushort)num3 & ((ushort)num | num2))));
		Llvm_lifetime_end_p0.Invoke(2L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
