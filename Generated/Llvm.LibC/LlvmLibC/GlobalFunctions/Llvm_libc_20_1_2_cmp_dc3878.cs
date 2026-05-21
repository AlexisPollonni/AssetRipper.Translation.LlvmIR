using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_cmp_dc3878
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cmpERKNS_6BigIntILm128ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cmp(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	[CleanName("Llvm_libc_20_1_2_cmp")]
	public unsafe static int Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Rhs)
	{
		int result = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		long num = 0L;
		int num2 = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 2L;
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
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = Lambda_Invoke_n4bwa8.Invoke(&anon_izyfb, *(long*)BigInt_128ul_false_unsigned_long_Index_ua9ih9.Invoke(Lhs, num), *(long*)BigInt_128ul_false_unsigned_long_Index_ua9ih9.Invoke(Rhs, num));
				if (num2 != 0)
				{
					result = num2;
					num4 = 1;
				}
				else
				{
					num4 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				switch (num4)
				{
				case 0:
					continue;
				}
				break;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			if (num4 == 2)
			{
				result = 0;
			}
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			return result;
		}
	}
}
