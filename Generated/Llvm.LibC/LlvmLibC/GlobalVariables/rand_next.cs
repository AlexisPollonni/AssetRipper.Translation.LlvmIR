using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_9rand_nextE")]
[DemangledName("__llvm_libc_20_1_2_::rand_next")]
internal static partial class rand_next
{
	[FixedAddressValueType]
	private static fputil_internal_FPStorage_v3nexn __value;

	public unsafe static fputil_internal_FPStorage_v3nexn* Pointer => unchecked((fputil_internal_FPStorage_v3nexn*)Unsafe.AsPointer(ref __value));

	public static fputil_internal_FPStorage_v3nexn Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static rand_next()
	{
		Value = new fputil_internal_FPStorage_v3nexn
		{
			val = 1L
		};
		PointerIndices.Register(Pointer);
	}
}
