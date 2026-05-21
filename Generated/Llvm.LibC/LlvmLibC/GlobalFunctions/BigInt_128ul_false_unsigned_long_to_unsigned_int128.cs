using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_to_unsigned_int128
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE2toIoEENS_3cpp9enable_ifIXaasr3cppE13is_integral_vIT_Entsr3cppE9is_same_vIS5_bEES5_E4typeEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned __int128> && !cpp::is_same_v<unsigned __int128, bool>, unsigned __int128>::type __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::to<unsigned __int128>() const")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<unsigned __int128> && !cpp::is_same_v<unsigned __int128, bool>, unsigned __int128>::type")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] Anon_izyfb7* This)
	{
		long num = 0L;
		Int128 @int = default(Int128);
		long num2 = 0L;
		long num3 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 128L;
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		unchecked
		{
			@int = (Int128)(UInt128)(*(ulong*)Array_unsigned_long_2ul_Index_j6w6uu.Invoke(&((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val, 0L));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 2L;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			for (num3 = 1L; (ulong)num3 < 2uL; num3++)
			{
				@int = NumericHelper.Add(y: NumericHelper.ShiftLeft((Int128)(UInt128)(*(ulong*)Array_unsigned_long_2ul_Index_j6w6uu.Invoke(&((Llvm_libc_20_1_2_BigInt_qdkjbh*)This)->Val, num3)), (Int128)(UInt128)(ulong)(64L * num3)), x: @int);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Int128 int2 = @int;
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(16L, &@int);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}
