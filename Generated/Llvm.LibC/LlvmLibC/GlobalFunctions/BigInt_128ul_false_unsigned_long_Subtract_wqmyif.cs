using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_Subtract_wqmyif
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEmiERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&) const")]
	[CleanName("BigInt_128ul_false_unsigned_long_Subtract")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Other)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh, This, 16L, isVolatile: false);
			BigInt_128ul_false_unsigned_long_sub_overflow.Invoke((Anon_izyfb7*)(&llvm_libc_20_1_2_BigInt_qdkjbh), Other);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_BigInt_qdkjbh.Val.Data);
		}
	}
}
