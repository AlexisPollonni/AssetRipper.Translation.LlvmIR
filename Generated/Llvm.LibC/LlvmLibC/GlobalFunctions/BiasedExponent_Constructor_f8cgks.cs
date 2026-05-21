using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BiasedExponent_Constructor_f8cgks
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE14BiasedExponentC2ENS4_8ExponentE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::BiasedExponent::BiasedExponent(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Exponent)")]
	[CleanName("BiasedExponent_Constructor")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("exp.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Exponent")] int Exp)
	{
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent = new Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
		{
			field_0 = 
			{
				field_0 = Exp
			}
		};
		TypedInt_unsigned_int_Constructor_znza9e.Invoke(This, TypedInt_int_ToInt32_626vzq.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent) + 127);
	}
}
