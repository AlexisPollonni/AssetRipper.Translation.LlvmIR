using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE9quiet_nanENS_4SignEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::quiet_nan(__llvm_libc_20_1_2_::Sign, unsigned short)")]
	public unsafe static short Invoke([MangledName("sign.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte Sign, [MangledName("v")][NativeType("unsigned short")] short V)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h = default(Fputil_internal_FPRepSem_i7nz4h);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(Fputil_internal_FPRepSem_i7nz4h);
		Fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h3 = default(Fputil_internal_FPRepSem_i7nz4h);
		anon_izyfb.Val = Sign;
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
		int field_ = Exponent_inf_bde7zj.Invoke();
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0 = field_;
		BiasedExponent_Constructor_jrjdb5.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0);
		short field_2 = Significand_msb_5rz537.Invoke();
		fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0 = field_2;
		Significand_Constructor_n44wpn.Invoke(&fputil_internal_FPRepSem_i7nz4h3, V);
		short field_3 = Internal_BitwiseOr_sf5vh5.Invoke(fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0, fputil_internal_FPRepSem_i7nz4h3.FPStorage.field_0);
		fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0 = field_3;
		FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva, FPStorage_fputil_FPType_0_encode.Invoke(anon_izyfb2.Val, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent.field_0.field_0, fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0));
		return fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0;
	}
}
