using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_signaling_nan
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE13signaling_nanENS_4SignEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::signaling_nan(__llvm_libc_20_1_2_::Sign, unsigned short)")]
	public unsafe static short Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte sign, [NativeType("unsigned short")] short v)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h3 = default(fputil_internal_FPRepSem_i7nz4h);
		anon_izyfb8.val = sign;
		short num = v;
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
		int field_ = Exponent_inf_bde7zj.Invoke();
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0 = field_;
		BiasedExponent_Constructor_jrjdb5.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3.field_0.field_0);
		if (num != 0)
		{
			Significand_Constructor_n44wpn.Invoke(&fputil_internal_FPRepSem_i7nz4h2, num);
		}
		else
		{
			short field_2 = Significand_msb_5rz537.Invoke();
			fputil_internal_FPRepSem_i7nz4h3.FPStorage.field_0 = field_2;
			short field_3 = internal_RightShift_ueqxwn.Invoke(fputil_internal_FPRepSem_i7nz4h3.FPStorage.field_0, 1);
			fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0 = field_3;
		}
		FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva2, FPStorage_fputil_FPType_0_encode.Invoke(anon_izyfb9.val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0, fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0));
		return fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0;
	}
}
