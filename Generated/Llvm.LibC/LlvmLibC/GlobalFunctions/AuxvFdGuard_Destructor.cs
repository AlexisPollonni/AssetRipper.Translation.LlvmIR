using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvFdGuard_Destructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11AuxvFdGuardD2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::~AuxvFdGuard()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			if (((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 != -1)
			{
				((delegate*<int, int>)Close.__pointer)(((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0);
			}
		}
	}
}
