using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11test_exceptEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::test_except(int)")]
internal static partial class fputil_test_except_int
{
	public unsafe static int Invoke(int excepts)
	{
		short num = 0;
		int num2 = 0;
		short num3 = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = fputil_internal_get_x87_status_word.Invoke();
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = fputil_internal_get_mxcsr.Invoke();
		llvm_lifetime_start_p0.Invoke(2L, &num3);
		num3 = fputil_internal_get_status_value_for_except_int.Invoke(excepts);
		int result = fputil_internal_exception_status_to_macro_unsigned_short.Invoke(unchecked((short)((ushort)num3 & ((ushort)num | num2))));
		llvm_lifetime_end_p0.Invoke(2L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
