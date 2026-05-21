using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_disable_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil14disable_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::disable_except(int)")]
	public unsafe static int Invoke([NativeType("int")] int excepts)
	{
		short num = 0;
		short num2 = 0;
		short status = 0;
		int num3 = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = internal_get_status_value_for_except.Invoke(excepts);
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = internal_get_x87_control_word.Invoke();
		llvm_lifetime_start_p0.Invoke(2L, &status);
		unchecked
		{
			status = (short)(((ushort)num2 ^ -1) & 0x3F);
			num2 = (short)((ushort)num2 | (ushort)num);
			internal_write_x87_control_word.Invoke(num2);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = internal_get_mxcsr.Invoke();
			num3 |= (ushort)num << 7;
			internal_write_mxcsr.Invoke(num3);
			int result = internal_exception_status_to_macro.Invoke(status);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(2L, &status);
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
