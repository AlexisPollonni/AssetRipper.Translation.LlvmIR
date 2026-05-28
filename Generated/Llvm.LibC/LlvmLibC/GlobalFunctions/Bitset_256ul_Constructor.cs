using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bitset_256ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::bitset()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			InlineArray4_Int64* data = &((Cpp_array_jgy3xh*)This)->Data;
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
