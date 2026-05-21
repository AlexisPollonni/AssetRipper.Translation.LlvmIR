using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_find_leading_one_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal16find_leading_oneImEET_S3_Ri")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::fputil::internal::find_leading_one<unsigned long>(unsigned long, int&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("mant")][NativeType("unsigned long")] long Mant, [MangledName("shift_length")][NativeType("int&")] void* Shift_length)
	{
		unchecked
		{
			*(int*)Shift_length = 0;
			if ((ulong)Mant > 0uL)
			{
				*(int*)Shift_length = (int)(63L - Cpp_countl_zero_unsigned_long.Invoke(Mant));
			}
			return 1L << (int)(uint)(*(int*)Shift_length);
		}
	}
}
