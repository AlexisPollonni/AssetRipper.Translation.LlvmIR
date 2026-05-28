using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_Subtract_gydwfz
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEmiEOS1_")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&&) const")]
	[CleanName("BigInt_128ul_false_unsigned_long_Subtract")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] Anon_izyfb7* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>&&")] Anon_izyfb7* Other)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&bigInt_qdkjbh, This, 16L, isVolatile: false);
			BigInt_128ul_false_unsigned_long_sub_overflow.Invoke((Anon_izyfb7*)(&bigInt_qdkjbh), Other);
			return *(Struct_fiz2nb*)(&bigInt_qdkjbh.Val.Data);
		}
	}
}
