using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atomic_unsigned_long_store
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6AtomicImE5storeEmNS0_11MemoryOrderENS0_11MemoryScopeE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::Atomic<unsigned long>::store(unsigned long, __llvm_libc_20_1_2_::cpp::MemoryOrder, __llvm_libc_20_1_2_::cpp::MemoryScope)")]
	public unsafe static void Invoke(fputil_internal_FPStorage_v3nexn* @this, [NativeType("unsigned long")] long rhs, [NativeType("__llvm_libc_20_1_2_::cpp::MemoryOrder")] MemoryOrder mem_ord, [NativeType("__llvm_libc_20_1_2_::cpp::MemoryScope")] MemoryScope mem_scope)
	{
		long num = rhs;
		void* ptr = Atomic_unsigned_long_addressof.Invoke(&@this->val);
		int num2 = Atomic_unsigned_long_order.Invoke(mem_ord);
		int num3 = Atomic_unsigned_long_scope.Invoke(mem_scope);
		void* ptr2 = Atomic_unsigned_long_addressof.Invoke(&num);
		unchecked
		{
			switch (num2)
			{
			default:
				switch (num3)
				{
				case 1:
					*(long*)ptr = *(long*)ptr2;
					break;
				default:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 2:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 3:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 4:
					*(long*)ptr = *(long*)ptr2;
					break;
				}
				break;
			case 3:
				switch (num3)
				{
				case 1:
					*(long*)ptr = *(long*)ptr2;
					break;
				default:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 2:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 3:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 4:
					*(long*)ptr = *(long*)ptr2;
					break;
				}
				break;
			case 5:
				switch (num3)
				{
				case 1:
					*(long*)ptr = *(long*)ptr2;
					break;
				default:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 2:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 3:
					*(long*)ptr = *(long*)ptr2;
					break;
				case 4:
					*(long*)ptr = *(long*)ptr2;
					break;
				}
				break;
			}
		}
	}
}
