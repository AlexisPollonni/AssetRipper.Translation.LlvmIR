using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_set_round
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9set_roundEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::set_round(int)")]
	public unsafe static int Invoke([MangledName("mode")][NativeType("int")] int Mode)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		int num4 = 0;
		int num5 = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = -21846;
		int result;
		if (Mode != 0)
		{
			if (Mode != 1024)
			{
				if (Mode != 2048)
				{
					if (Mode != 3072)
					{
						result = 1;
						goto IL_012a;
					}
					num = 3;
				}
				else
				{
					num = 2;
				}
			}
			else
			{
				num = 1;
			}
		}
		else
		{
			num = 0;
		}
		Llvm_lifetime_start_p0.Invoke(2L, &num2);
		unchecked
		{
			num2 = (short)((ushort)num << 10);
			Llvm_lifetime_start_p0.Invoke(2L, &num3);
			num3 = Internal_get_x87_control_word.Invoke();
			num3 = (short)(((ushort)num3 & -3073) | (ushort)num2);
			Internal_write_x87_control_word.Invoke(num3);
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = (ushort)num << 13;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = Internal_get_mxcsr.Invoke();
			num5 = (num5 & -24577) | num4;
			Internal_write_mxcsr.Invoke(num5);
			result = 0;
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(2L, &num3);
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			goto IL_012a;
		}
		IL_012a:
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
