using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9set_roundEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::set_round(int)")]
internal static partial class fputil_set_round_int
{
	public unsafe static int Invoke(int mode)
	{
		short num = 0;
		short num2 = 0;
		short num3 = 0;
		int num4 = 0;
		int num5 = 0;
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = -21846;
		int result;
		if (mode != 0)
		{
			if (mode != 1024)
			{
				if (mode != 2048)
				{
					if (mode != 3072)
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
		llvm_lifetime_start_p0.Invoke(2L, &num2);
		unchecked
		{
			num2 = (short)((ushort)num << 10);
			llvm_lifetime_start_p0.Invoke(2L, &num3);
			num3 = fputil_internal_get_x87_control_word.Invoke();
			num3 = (short)(((ushort)num3 & -3073) | (ushort)num2);
			fputil_internal_write_x87_control_word_unsigned_short.Invoke(num3);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = (ushort)num << 13;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = fputil_internal_get_mxcsr.Invoke();
			num5 = (num5 & -24577) | num4;
			fputil_internal_write_mxcsr_unsigned_int.Invoke(num5);
			result = 0;
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(2L, &num3);
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			goto IL_012a;
		}
		IL_012a:
		llvm_lifetime_end_p0.Invoke(2L, &num);
		return result;
	}
}
