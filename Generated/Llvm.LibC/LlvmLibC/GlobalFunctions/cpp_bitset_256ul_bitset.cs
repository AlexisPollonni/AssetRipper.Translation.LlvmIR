using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::bitset()")]
internal static partial class cpp_bitset_256ul_bitset
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			InlineArray4_Int64* data = &((cpp_array_jgy3xh*)@this)->Data;
			*(long*)data = 0L;
			nint num = (nint)((byte*)data + 8);
			long* ptr = (long*)data + 4;
			while (true)
			{
				void* ptr2 = (void*)num;
				*(long*)ptr2 = 0L;
				long* ptr3 = (long*)ptr2 + 1;
				if (ptr3 != ptr)
				{
					num = (nint)ptr3;
					continue;
				}
				break;
			}
		}
	}
}
