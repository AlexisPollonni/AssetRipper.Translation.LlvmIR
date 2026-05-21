using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EC2ENS0_6FPBitsIDF16_EE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::NormalFloat(__llvm_libc_20_1_2_::fputil::FPBits<_Float16>)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk* This, [MangledName("bits.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>")] short Bits)
	{
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = Bits;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2, &llvm_libc_20_1_2_fputil_FPBits_2fahva, 2L, isVolatile: false);
		NormalFloat_Float16_init_from_bits.Invoke(This, llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EC2ENS_4SignEit")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned short)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk* This, [MangledName("s.coerce")][NativeType("__llvm_libc_20_1_2_::Sign")] sbyte S, [MangledName("e")][NativeType("int")] int E, [MangledName("m")][NativeType("unsigned short")] short M)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		anon_izyfb.Val = S;
		short mantissa = M;
		This->Exponent = E;
		This->Mantissa = mantissa;
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Sign, &anon_izyfb, 1L, isVolatile: false);
		unchecked
		{
			if ((ushort)This->Mantissa < 1024)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = NormalFloat_Float16_evaluate_normalization_shift.Invoke(This, This->Mantissa);
				int num2 = num;
				short* mantissa2 = &This->Mantissa;
				*mantissa2 = (short)((ushort)(*mantissa2) << num2);
				This->Exponent -= num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
