using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_BigInt_192ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEC2ILm192ELb0EmEERKNS0_IXT_EXT0_ET1_EE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::BigInt<192ul, false, unsigned long>(__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long> const&)")]
	public unsafe static void Invoke([MangledName("this")] BigInt_76gxx6* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long> const&")] BigInt_khh67p* Other)
	{
		sbyte b = 0;
		long num = 0L;
		Llvm_memset_p0_i64.Invoke(&This->Val.Data, 0, 40L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				long num2 = *(long*)BigInt_192ul_false_unsigned_long_Index.Invoke(Other, num);
				*(long*)Array_unsigned_long_5ul_Index_wu6ki8.Invoke(&This->Val, num) = num2;
			}
			BigInt_320ul_false_unsigned_long_extend.Invoke(This, num, Is_neg: false);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
