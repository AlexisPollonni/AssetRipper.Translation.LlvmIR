using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_int_ToUInt32_xxvxbv
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE8TypedIntIjEcvjEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::TypedInt<unsigned int>::operator unsigned int() const")]
	[CleanName("TypedInt_unsigned_int_ToUInt32")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0;
	}
}
