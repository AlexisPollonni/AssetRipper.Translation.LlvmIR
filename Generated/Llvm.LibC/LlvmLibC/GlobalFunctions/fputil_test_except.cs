using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_test_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11test_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::test_except(int)")]
	public unsafe static int Invoke([NativeType("int")] int excepts)
	{
		short num = 0;
		int num2 = 0;
		short num3 = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = internal_get_x87_status_word.Invoke();
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = internal_get_mxcsr.Invoke();
		llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = internal_get_status_value_for_except.Invoke(excepts);
		int result = internal_exception_status_to_macro.Invoke(unchecked((short)((ushort)num3 & ((ushort)num | num2))));
		llvm_lifetime_end_p0.Invoke(2L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
