using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_enable_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil13enable_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::enable_except(int)")]
	public unsafe static int Invoke([MangledName("excepts")][NativeType("int")] int Excepts)
	{
		short num = 0;
		short num2 = 0;
		short status = 0;
		int num3 = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = Internal_get_status_value_for_except.Invoke(Excepts);
		Llvm_lifetime_start_p0.Invoke(2L, &num2);
		num2 = Internal_get_x87_control_word.Invoke();
		Llvm_lifetime_start_p0.Invoke(2L, &status);
		unchecked
		{
			status = (short)(((ushort)num2 ^ -1) & 0x3F);
			num2 = (short)((ushort)num2 & ((ushort)num ^ -1));
			Internal_write_x87_control_word.Invoke(num2);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = Internal_get_mxcsr.Invoke();
			num3 &= ((ushort)num << 7) ^ -1;
			Internal_write_mxcsr.Invoke(num3);
			int result = Internal_exception_status_to_macro.Invoke(status);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(2L, &status);
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
