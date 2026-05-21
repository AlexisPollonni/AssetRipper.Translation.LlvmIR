using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cmp_m6db9g
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cmpERKNS_6BigIntILm256ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cmp(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	[CleanName("cmp")]
	public unsafe static int Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* rhs)
	{
		int result = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		long num = 0L;
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 4L;
		unchecked
		{
			int num4;
			while (true)
			{
				long num3 = num;
				num = num3 + -1L;
				if ((ulong)num3 <= 0uL)
				{
					num4 = 2;
					break;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = lambda_Invoke_zf68nh.Invoke(&anon_izyfb8, *(long*)BigInt_256ul_false_unsigned_long_Index_g5vf7y.Invoke(lhs, num), *(long*)BigInt_256ul_false_unsigned_long_Index_g5vf7y.Invoke(rhs, num));
				if (num2 != 0)
				{
					result = num2;
					num4 = 1;
				}
				else
				{
					num4 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				switch (num4)
				{
				case 0:
					continue;
				}
				break;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			if (num4 == 2)
			{
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			return result;
		}
	}
}
