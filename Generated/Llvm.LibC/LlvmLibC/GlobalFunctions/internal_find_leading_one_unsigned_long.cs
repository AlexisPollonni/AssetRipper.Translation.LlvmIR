using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_find_leading_one_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal16find_leading_oneImEET_S3_Ri")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::fputil::internal::find_leading_one<unsigned long>(unsigned long, int&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("unsigned long")] long mant, [NativeType("int&")] void* shift_length)
	{
		unchecked
		{
			*(int*)shift_length = 0;
			if ((ulong)mant > 0uL)
			{
				*(int*)shift_length = (int)(63L - cpp_countl_zero_unsigned_long.Invoke(mant));
			}
			return 1L << (int)(uint)(*(int*)shift_length);
		}
	}
}
