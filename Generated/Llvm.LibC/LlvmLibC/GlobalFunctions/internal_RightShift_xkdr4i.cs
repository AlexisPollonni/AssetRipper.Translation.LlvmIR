using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_RightShift_xkdr4i
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalrsENS1_9FPStorageILNS0_6FPTypeE1EE11SignificandEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator>>(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Significand, int)")]
	[CleanName("internal_RightShift")]
	public unsafe static int Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::Significand")] int a, [NativeType("int")] int shift)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
		{
			field_0 = 
			{
				field_0 = a
			}
		};
		Significand_Constructor_vz3zem.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2, TypedInt_unsigned_int_to_storage_type_c8hg2g.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent3) >>> shift);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2.field_0.field_0;
	}
}
